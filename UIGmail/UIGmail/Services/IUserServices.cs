using UIGmail.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UIGmail.Services
{
    public interface IUserServices
    {
        Task<List<User>> GetAllContacts();

    }
}
