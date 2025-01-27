﻿using System;
using Microsoft.AspNetCore.SignalR;

namespace Chatty.Hubs;

public class ChatHub : Hub
{
	public ChatHub()
	{
	}

	public async Task SendMessage(string user, string message)
    {
		await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}