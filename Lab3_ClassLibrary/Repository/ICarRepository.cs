using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ClassLibrary.Repository
{
    internal class ICarRepository
    {
    }
}

dotnet ef dbcontext scaffold 
"Server=(local);uid=sa;pwd=123456;database=MyStock"
Microsoft.EntityFrameworkCore.SqlServer --output-dir DataAccess
dotnet ef dbcontext scaffold 
"Server=(local);uid=sa;pwd=123456;database=MyStock" 
Microsoft.EntityFrameworkCore.SqlServer --output-dir DataAccess