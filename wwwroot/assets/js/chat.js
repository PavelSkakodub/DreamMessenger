//регистрация обработчика события для всей страницы (событие загрузки контента)
document.addEventListener("DOMContentLoaded", () => {

    //создаём подключение с логированием и переподключением через время
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/chatHub")
        .configureLogging(signalR.LogLevel.Information)
        .withAutomaticReconnect([0, 500, 5000, 30000])
        .build();

    //обработка отправки сообщения
    connection.on("ReceiveMessage", (userName, message) =>
    {
        //текущее время в формате чч:мм
        var nowTime = new Date().toLocaleTimeString().slice(0, -3);
        //получаем контейнер сообщений по id
        var div = document.getElementById("messagesList");
        //html-код сообщения с переданными значениями
        var messageTemplate = `
                    <div class="chats">
                        <div class="chat-avatar"><img src="https://i.pinimg.com/736x/f5/27/41/f52741fb62bf1d821948a49204406bdc.jpg" class="rounded-circle dreams_chat" alt="image"></div>
                        <div class="chat-content">
                            <div class="message-content"> ${message} <div class="chat-time">
                                    <div>
                                        <div class="time"><i class="fas fa-clock"></i> ${nowTime}</div>
                                    </div>
                                </div>
                            </div>
                            <div class="chat-profile-name">
                                <h6> ${userName} </h6>
                            </div>
                        </div>
                        <div class="chat-action-btns ms-3">
                            <div class="chat-action-col"><a class="#" href="#" data-bs-toggle="dropdown"><i class="fas fa-ellipsis-h"></i></a>
                                <div class="dropdown-menu dropdown-menu-end"><a href="#" class="dropdown-item dream_profile_menu">Copy <span><i class="far fa-copy"></i></span></a><a href="#" class="dropdown-item">Save <span class="material-icons">save</span></a> <a href="#" class="dropdown-item">Forward <span><i class="fas fa-share"></i></span></a><a href="#" class="dropdown-item">Delete <span><i class="far fa-trash-alt"></i></span></a></div>
                            </div>
                        </div>
                    </div>
                    `
        //вставляем в конец html сообщение
        div.insertAdjacentHTML("beforeend", messageTemplate);
        //получаем элемент прокрутки
        var slimScroll = document.getElementById("slimScroll");
        //опускаем вниз до конца
        slimScroll.scrollTop = slimScroll.scrollHeight;
    });
    
    //обработка клика отправки сообщения (добавляем событие)
    document.getElementById("sendMessage").addEventListener("click", async () =>
    {
        //ищем элементы по id и получаем их значения
        const userName = document.getElementById("userInput").value;
        const message = document.getElementById("messageInput").value;
        var UserId = document.getElementById("userIdentity").value;

        //если сообщение не пустое 
        if (!message.trim() == '')
        {
            try //вызываем отправку сообщения и очищаем поле ввода
            {
                await connection.invoke("SendMessage", UserId, userName, message);
                document.getElementById("messageInput").value = '';
            }
            catch (err) //записываем ошибки
            {
                console.error(err);
            }
        }
    });

    //функция старта подключения
    async function start()
    {
        try //открываем подключение и пишем в консоль
        {
            await connection.start();
            console.log("SignalR Connected.");
        }
        catch (err) //записываем ошибки
        {
            console.log(err);
        }
    };

    //обработка закрытия подключения
    connection.onclose(error =>
    {
        //добавляем в консоль состояние отключения 
        console.assert(connection.state === signalR.HubConnectionState.Disconnected);
        //отключаем ввод сообщения
        document.getElementById("messagesInput").disabled = true;
        //пишем что нужно перезагрузить страницу
        const li = document.createElement("li");
        li.textContent = `Connection closed due to error "${error}". Try refreshing this page to restart the connection.`;
        document.getElementById("messagesList").appendChild(li);
    });

    //старт подключения
    start();
});
