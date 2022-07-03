using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoinApi.Migrations
{
    public partial class InicialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 1,
                column: "ImagenUrl",
                value: "https://cdn.pixabay.com/photo/2021/04/30/16/47/btc-logo-6219386_960_720.png");

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 5,
                column: "ImagenUrl",
                value: "https://thumbs.dreamstime.com/z/s%C3%ADmbolo-de-oro-del-binance-crypto-la-moneda-aislado-en-el-fondo-blanco-137343964.jpg");

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 6,
                column: "ImagenUrl",
                value: "https://previews.123rf.com/images/ryzhi/ryzhi1712/ryzhi171200070/91650546-moneda-de-oro-de-la-moneda-de-crypto-con-s%C3%ADmbolo-de-la-ondulaci%C3%B3n-del-oro-en-el-anverso-aislado-en-e.jpg?fj=1");

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 7,
                column: "ImagenUrl",
                value: "https://previews.123rf.com/images/architect9/architect92004/architect9200400120/145157172-el-fondo-de-criptomonedas-es-perfecto-para-cualquier-tipo-de-presentaci%C3%B3n-de-noticias-o-informaci%C3%B3n-.jpg?fj=1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 1,
                column: "ImagenUrl",
                value: "https://png.monster/bitcoin-icon-3/ ");

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 5,
                column: "ImagenUrl",
                value: "https://www.pngwing.com/es/free-png-masau");

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 6,
                column: "ImagenUrl",
                value: "https://www.pngwing.com/en/free-png-afkuk");

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 7,
                column: "ImagenUrl",
                value: "https://www.pngwing.com/en/free-png-kgbjx");
        }
    }
}
