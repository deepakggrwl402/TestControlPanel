using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestControlPanel.Domain.Entities;

namespace TestControlPanel.Infra.Context
{
    public class TestControlPanelDBContext : DbContext
    {
        public TestControlPanelDBContext(DbContextOptions<TestControlPanelDBContext> options) : base(options)
        {

        }
        public DbSet<TestCase> TestCases { get; set; }
    }
}
