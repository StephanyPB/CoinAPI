using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoinApi.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    MonedaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<double>(type: "REAL", nullable: true),
                    ImagenUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.MonedaId);
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 1, "Bitcoin", "https://png.monster/bitcoin-icon-3/ ", 10000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 2, "Ethereum", "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png", 9000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 3, "Cardano", "https://www.pngall.com/wp-content/uploads/10/Cardano-Crypto-Logo-PNG-Free-Image.png", 8000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 4, "Tether", "https://iconape.com/wp-content/files/ac/209643/png/tether-usdt-logo.png", 7000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 5, "Binance Coin", "https://www.pngwing.com/es/free-png-masau", 6000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 6, "Repple", "https://www.pngwing.com/en/free-png-afkuk", 5000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 7, "Dogecoin", "https://www.pngwing.com/en/free-png-kgbjx", 4000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 8, "USDCoin", "https://www.pngall.com/wp-content/uploads/10/USD-Coin-Logo-PNG-Pic.png", 3000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 9, "Terra", "https://png.pngtree.com/png-clipart/20220131/original/pngtree-d-front-rendering-cryptocurrency-luna-or-terra-blue-coin-with-cartoon-png-image_7261248.png", 2000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImagenUrl", "Valor" },
                values: new object[] { 10, "Solana", "https://www.pngall.com/wp-content/uploads/10/Solana-Crypto-Logo-PNG-File.png", 1000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins");
        }
    }
}
