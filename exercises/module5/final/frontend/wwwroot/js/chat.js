"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

var li = null;

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

function scrollToBottom() {
    document.querySelector('.chat-messages').scrollTop = document.querySelector('.chat-messages').scrollHeight;
    window.scrollTo(0, document.body.scrollHeight);
}

connection.on("NewResponse", function () {
    li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
});

connection.on("ResponseDone", function () {
    li = null;
    scrollToBottom();
});

connection.on("ReceiveMessagePart", function (message) {
    li.appendChild(document.createTextNode(message));
    scrollToBottom();
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var message = document.getElementById("messageInput").value;
    var userMessage = document.createElement("li");
    userMessage.innerText = "You: " + message;
    document.getElementById("messagesList").appendChild(userMessage);

    scrollToBottom();

    connection.invoke("SendMessage", message).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("messageInput").value = "";
    event.preventDefault();
});
