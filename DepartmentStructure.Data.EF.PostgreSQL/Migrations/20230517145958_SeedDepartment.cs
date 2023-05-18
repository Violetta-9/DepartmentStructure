using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentStructure.Data.EF.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class SeedDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Отдел по обслуживанию клиентов',NULL)");

            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Отдел продаж', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел по обслуживанию клиентов'))");
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Отдел оптовых  продаж', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел продаж'))");
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Отдел розничных  продаж', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел продаж'))");
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Отдел логистики', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел по обслуживанию клиентов'))");
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Склад', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел логистики'))");
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Отдел доставки', (SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Отдел логистики'))");


            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Производственный отдел', NULL)");
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Инженерный отдел',(SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Производственный отдел'))");
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Отдел проверки качества',(SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Производственный отдел'))");
            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Отдел закупок',(SELECT ""Id"" FROM ""Departments"" WHERE ""Title"" = 'Производственный отдел'))");

            migrationBuilder.Sql(@"INSERT INTO ""Departments"" (""Title"",""ParentDepartmentId"") VALUES('Бухгалтерия',NULL)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
