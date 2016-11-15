﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DSharpPlus
{
    public class DiscordUser : SnowflakeObject
    {
        [JsonProperty("username")]
        public string Username { get; internal set; }
        [JsonProperty("discriminator")]
        public int Discriminator { get; internal set; }
        [JsonProperty("avatar_hash")]
        public string AvatarHash { get; internal set; }
        [JsonIgnore]
        public string AvatarUrl => $"";
        [JsonProperty("is_bot")]
        public bool IsBot { get; internal set; }
        [JsonProperty("mfa_enabled")]
        public bool? MFAEnabled { get; internal set; }
        [JsonProperty("verified")]
        public bool? Verified { get; internal set; }
        [JsonProperty("email")]
        public string Email { get; internal set; }

        internal static DiscordUser FromJson(JObject UserObject)
        {
            DiscordUser user = new DiscordUser();

            user.ID = UserObject.Value<ulong>("id");
            user.Username = UserObject.Value<string>("username");
            user.Discriminator = UserObject.Value<int>("discriminator");
            user.AvatarHash = UserObject.Value<string>("avatar");
            user.MFAEnabled = UserObject.Value<bool>("mfa_enabled");
            user.Verified = UserObject.Value<bool>("verified");
            user.Email = UserObject.Value<string>("email");

            return user;
        }
    }
}
