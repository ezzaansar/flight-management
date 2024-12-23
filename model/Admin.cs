using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3.Models
{
    public record Admin
    (
        int Id,
        string UserName,
        int PasswordHash,
        string Email
    );
}
