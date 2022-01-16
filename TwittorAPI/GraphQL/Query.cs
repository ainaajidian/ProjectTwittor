using System;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TwittorAPI.Dtos;
using TwittorAPI.Kafka;
using TwittorAPI.Models;


namespace TwittorAPI.GraphQL
{
    public class Query
    {
        //Show All Twit
        public async Task<IQueryable<Twittor>> GetTwittors(
            [Service] ProjectTwittorContext context,
            [Service] IOptions<KafkaSettings> kafkaSettings)
        {
            var key = "GetTwittors-" + DateTime.Now.ToString();
            var val = JObject.FromObject(new { Message = "GraphQL Query GetTwittors" }).ToString(Formatting.None);

            await KafkaHelper.SendMessage(kafkaSettings.Value, "logging", key, val);
            return context.Twittors;
        }

        //Show Profile
        public async Task<IQueryable<UserData>> GetUsers(
            [Service] ProjectTwittorContext context,
            [Service] IOptions<KafkaSettings> kafkaSettings)
        {
            var key = "getusers-" + DateTime.Now.ToString();
            var val = JObject.FromObject(new { Message = "GraphQL Query GetUsers" }).ToString(Formatting.None);
            await KafkaHelper.SendMessage(kafkaSettings.Value, "logging", key, val);
            return context.Users.Select(p => new UserData()
            {
                Id = p.UserId,
                FullName = p.FullName,
                Email = p.Email,
                Username = p.Username
            });
        }

        //Show All User Role
        public async Task<IQueryable<UserRole>> GetUserRoles(
            [Service] ProjectTwittorContext context,
            [Service] IOptions<KafkaSettings> kafkaSettings)
        {
            var key = "GetUserRoles-" + DateTime.Now.ToString();
            var val = JObject.FromObject(new { Message = "GraphQL Query GetUserRoles" }).ToString(Formatting.None);

            await KafkaHelper.SendMessage(kafkaSettings.Value, "logging", key, val);
            return context.UserRoles;
        }
    }
}