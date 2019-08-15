"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/led1Hub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    connection.invoke("SendMessage", true).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

connection.on("ReceiveMessage", function (b) {   
    var li = document.createElement("li");
    li.textContent = "x";
    document.getElementById("messagesList").appendChild(li);
});

