using MonkeyCache.FileStore;
using UIGmail.Helpers;
using UIGmail.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UIGmail.Services
{
    public class GmailServices : IUserServices
    {

        public async Task<List<User>> GetAllContacts()
        {
            Barrel.ApplicationId = Config.KeyCache;
            Barrel.Current.EmptyAll();
            if (!Barrel.Current.IsExpired(key:Config.KeyCache))
            {
                return Barrel.Current.Get<List<User>>(key: Config.KeyCache);
            }
          
            var list= new List<User>() { new User() { 
            ID=1,
            Color=2,
            Name = "YouTube ",
            LastName = "youtube",
            Mail = "youtube-subscriptions.bounces.google.com",
            Message = new Message(){Description=" *NEW* HELICOPTERS ARE INSANE!! - Fortnite Funny Fails and WTF Momen CC Trolling You were sent this email because you chose to receive updates from BCC Trolling. If you don't want these updates anymore, you can unsubscribe here. © 2020 YouTube, LLC 901 Cherry Ave, San Bruno, CA 94066" }
            },new User() {
            ID=1,
            Color=4,
            Name = "GitHub ",
            LastName = "GitHub",
            Mail = "gmail.github.com",
            Message = new Message(){Description=" Explore code and developers on GitHub this week, the week of Mar 10 - Mar 17.Here's what we found based on your interests..." }

            }, new User() {
            ID=1,
            Name = "Rockstar ",
            LastName = "Propaganda ",
            Mail = "donotreply@newsletter.rockstargames.com",
            Message = new Message(){Description=" The Rockstar End of Winter Sale – ENDS TOMORROW Time is running out to save on all full games available on the Rockstar Games Launcher - including Red Dead Redemption 2 and Grand Theft Auto V. Plus, get 50% off classic Rockstar titles and 40% off select gear including apparel and collectibles from the Red Dead Redemption 2 Outlaw Essentials Collection." }
            }, new User() {
            ID=1,
            Color=8,
            Name = "Daihanna",
            LastName = "Vasquez",
            Mail = "DaihannaV@gmail.com",
            Message = new Message(){Description=" EFECTOS DEL TECNOESTRÉS EN UNIVERSITARIOS- ASIGNACIÓN 4 - Invitation to edit" }
            }, new User() {
            ID=1,
            Color=9,
            Name = "Popular",
            LastName = "Estados",
            Mail = "estados@popularenlinea.com",
            Message = new Message(){Description=" Tenemos a bien informarle que ya está disponible su estado de cuenta correspondiente al último corte. Puede visualizarlo accediendo a Popular en línea, App Popular, tPago o consultarlo llamando a Telebanco Popular." }
            },  };
            Barrel.Current.Add(key: Config.KeyCache, data: list, expireIn: TimeSpan.FromDays(1));
            return list;
        }
    }
}
