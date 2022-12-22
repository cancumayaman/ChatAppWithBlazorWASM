﻿using ChatAppWithBlazorWASM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChatAppWithBlazorWASM.Client.Managers
{
public interface IChatManager
{
    Task<List<ApplicationUser>> GetUsersAsync();
    Task SaveMessageAsync(ChatMessage message);
    Task<List<ChatMessage>> GetConversationAsync(string contactId);
    Task<ApplicationUser> GetUserDetailsAsync(string userId);
}
}
