using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL{
public class Contexto: DbContext
{
    public DbSet<Coins> Coins{get; set;}

    public Contexto(DbContextOptions<Contexto> options) : base(options){
    }

     protected override void OnModelCreating(ModelBuilder modelBuilder){
       
        modelBuilder.Entity<Coins>().HasData(
            
            new Coins(){
                MonedaId = 1,Descripcion = "Bitcoin",
                Valor = 10000, ImagenUrl ="https://cdn.pixabay.com/photo/2021/04/30/16/47/btc-logo-6219386_960_720.png"
            },
             new Coins(){
                MonedaId = 2,Descripcion = "Ethereum",
                Valor = 9000, ImagenUrl ="https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png"
            },
            new Coins(){
                MonedaId = 3, Descripcion = "Cardano",
                Valor = 8000, ImagenUrl ="https://www.pngall.com/wp-content/uploads/10/Cardano-Crypto-Logo-PNG-Free-Image.png"
            },
            new Coins(){
                MonedaId = 4,  Descripcion = "Tether",
                Valor = 7000,ImagenUrl ="https://iconape.com/wp-content/files/ac/209643/png/tether-usdt-logo.png"
            },
             new Coins(){
                MonedaId = 5, Descripcion = "Binance Coin",
                Valor = 6000,  ImagenUrl ="https://thumbs.dreamstime.com/z/s%C3%ADmbolo-de-oro-del-binance-crypto-la-moneda-aislado-en-el-fondo-blanco-137343964.jpg"
            },
             new Coins(){
                MonedaId = 6,Descripcion = "Repple",
                Valor = 5000, ImagenUrl ="https://previews.123rf.com/images/ryzhi/ryzhi1712/ryzhi171200070/91650546-moneda-de-oro-de-la-moneda-de-crypto-con-s%C3%ADmbolo-de-la-ondulaci%C3%B3n-del-oro-en-el-anverso-aislado-en-e.jpg?fj=1"
            },
             new Coins(){
                MonedaId = 7,Descripcion = "Dogecoin",
                Valor = 4000, ImagenUrl ="https://previews.123rf.com/images/architect9/architect92004/architect9200400120/145157172-el-fondo-de-criptomonedas-es-perfecto-para-cualquier-tipo-de-presentaci%C3%B3n-de-noticias-o-informaci%C3%B3n-.jpg?fj=1"
            },
             new Coins(){
                MonedaId = 8, Descripcion = "USDCoin",
                Valor = 3000, ImagenUrl ="https://www.pngall.com/wp-content/uploads/10/USD-Coin-Logo-PNG-Pic.png"
            },
             new Coins(){
                MonedaId = 9, Descripcion = "Terra",
                Valor = 2000,  ImagenUrl ="https://png.pngtree.com/png-clipart/20220131/original/pngtree-d-front-rendering-cryptocurrency-luna-or-terra-blue-coin-with-cartoon-png-image_7261248.png"
            },
             new Coins(){
                MonedaId = 10, Descripcion = "Solana",
                Valor = 1000,  ImagenUrl ="https://www.pngall.com/wp-content/uploads/10/Solana-Crypto-Logo-PNG-File.png"
            }
        );
    }
}
}
