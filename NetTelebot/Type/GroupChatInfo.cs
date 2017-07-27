﻿using System;
using NetTelebot.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NetTelebot.Type
{
    /// <summary>
    /// This object represents a group chat.
    /// </summary>
    [Obsolete]
    public class GroupChatInfo : IConversationSource
    {
        internal GroupChatInfo(string jsonText)
        {
            Parse(jsonText);
        }

        internal GroupChatInfo(JObject jsonObject)
        {
            Parse(jsonObject);
        }

        private void Parse(JObject jsonObject)
        {
            Id = jsonObject["id"].Value<long>();
            Title = jsonObject["title"].Value<string>();
        }

        private void Parse(string jsonText)
        {
            JObject jsonObject = (JObject)JsonConvert.DeserializeObject(jsonText);
            Parse(jsonObject);
        }

        /// <summary>
        /// Unique identifier for this group chat
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Unique identifier for this group chat
        /// </summary>
        public string Title { get; set; }
    }
}
