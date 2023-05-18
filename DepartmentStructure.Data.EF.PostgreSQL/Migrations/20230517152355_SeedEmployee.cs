using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentStructure.Data.EF.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Михаил', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел оптовых  продаж'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Александр', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел оптовых  продаж'))");

            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Николай', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел розничных  продаж'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Эдуард', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел розничных  продаж'))");

            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Анна', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Склад'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Мария', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Склад'))");

            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Вероника', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел доставки'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Никита', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел доставки'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Александра', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел доставки'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Алексей', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел доставки'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Степан', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел доставки'))");


            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Феликс', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Инженерный отдел'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Сергей', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Инженерный отдел'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Владимир', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Инженерный отдел'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Владислав', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Инженерный отдел'))");

            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Татьяна', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел проверки качества'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Ольга', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел проверки качества'))");

            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Надежда', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел закупок'))");
            

            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Роман', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Бухгалтерия'))");
            migrationBuilder.Sql(@"INSERT INTO ""Employees"" (""Name"", ""DepartmentId"") VALUES ('Анастасия', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Бухгалтерия'))");



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
