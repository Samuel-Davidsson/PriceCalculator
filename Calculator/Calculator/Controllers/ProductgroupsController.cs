using System.Collections.Generic;
using System.Linq;
using Calculator.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    public class ProductgroupsController : Controller
    {
        [HttpGet()]
        public IActionResult Getall()
        {
            var productgroups = new List<Productgroup>();
            {
                productgroups.Add(new Productgroup() { Id = 1, Name = "Enkla produkten", Description = "För dig som vill ha en enkel och kostnadseffektiv lösning!", ImageUrl = "http://genesismerchant.com/gen-cont/uploads/2014/10/Foundry-POS-image-2.jpg"});
                productgroups.Add(new Productgroup() { Id = 2, Name = "Mellan produkten", Description = "För dig som vill ha en enkel och kostnadseffektiv lösning!", ImageUrl = "http://genesismerchant.com/gen-cont/uploads/2014/10/Foundry-POS-image-2.jpg"});
                productgroups.Add(new Productgroup() { Id = 3, Name = "Stora produkten", Description = "För dig som vill ha en enkel och kostnadseffektiv lösning!", ImageUrl = "http://genesismerchant.com/gen-cont/uploads/2014/10/Foundry-POS-image-2.jpg"});
                productgroups.Add(new Productgroup() { Id = 4, Name = "Mega produkten", Description = "För dig som vill ha en enkel och kostnadseffektiv lösning!", ImageUrl = "http://genesismerchant.com/gen-cont/uploads/2014/10/Foundry-POS-image-2.jpg"});
            };

            return Ok(productgroups);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var products = new List<Product>();
            products.Add(new Product() { Id=0, Name = "Betalsätt faktura", Price = 49.00m, IsSelected=true, Description= "Ange betalsätt faktura och kontera försäljningen mot ett eget bokföringskonto på dagsrapporten. En extra internslip skrivs ut som du kan fakturera efter i ditt bokföringssystem.", IsFactualCost=false });
            products.Add(new Product() { Id = 1,Name = "Valfritt betalsätt", Price = 49.00m, IsSelected=false, Description= "Med det här betalsättet kan du själv ange vad det skall ha för namn och till vilket bokföringskonto du vill kontera intäkten på dagsrapporten.", IsFactualCost=false});
            products.Add(new Product() { Id = 2, Name = "Betalsätt kuponger", Price = 49.00m, IsSelected=false, Description= "Med det här tillägget får du ett nytt betalmedel som heter kupong som du enkelt kan kontera mot ett eget boföringskonto på dagsrapporten för enkel avstämning av kassan!", IsFactualCost=false});
            products.Add(new Product() { Id = 3, Name = "SEQR Mobilbetalning", Description = "SEQR är ett smart, miljövänligt och billigt alternativ till vanlig kreditkortsbetalning. Förutom att transaktioner endast kostar hälften så mycket som vanliga kreditkortsbetalningar så behöver du inte någon extrautrustning vid dina kassor. Se www.seqr.se för mer information.", IsFactualCost=false });

            var products2 = new List<Product>();
            products2.Add(new Product() { Id = 4, Name = "Present - & rabattkort", Price = 79.00m, IsSelected = true, Description = "Present- och rabattkort med magnetremsa ger en enkel och proffsig hantering. Du tar ut en Excel lista med alla transaktioner och har 100% kontroll. Drar du kortet i rabattdialogen får varorna du valt den procentsats du tidigare satt på kortet. Du kan använda vilka kort som helst med magnetremsa!", IsFactualCost = false });
            products2.Add(new Product() { Id = 5, Name = "Kampanjvaror ", Price = 79.00m, IsSelected = false, Description = "Du sätter datumperiod och ett fast kampanjpris som du vill skall gälla under kampanjen.När kampanjen är slut säljs varan återigen med ditt normala pris.", IsFactualCost = false});
            products2.Add(new Product() { Id = 6, Name = "Försäljning i Euro", Price = 49.00m, IsSelected = false, Description = "Med ett enkelt klick på eurosymbolen på kassabilden visar du alla priser mot kund på kunddisplayen i euro och du tar betalt i valfria euro valörer. Kvittot och dagsrapporten visar både kr och euro. Kursen hämtas automatiskt varje gång du startar programmet och du väljer hur många procent du alltid vill tjäna.", IsFactualCost = false });
            products2.Add(new Product() { Id = 7, Name = "Stafflat pris", Price = 19.00m, Description = "Köp 3 och betala för 2 med vårt tillägg för staffling. Du får en ny flik på varor där du anger antal och ett nytt pris som gäller om kunden köper antalet du angett.", IsFactualCost=false });
            products2.Add(new Product() { Id = 8, Name = "Kombinerad rabatt", Price = 99.00m, Description= "Köp 3 och betala för 2! Du har säkert sett erbjudande i kassan för Marabou chokladbitar där du kan plocka vilka tre bitar du vill och betala för två. Med det här tillägget kan du kombinera samma eller olika varor och ge en rabatt som avdrag på kvittot. Självklart kan du ange hur många som skall uppfyllas för att få rabatten.", IsFactualCost=false });
            products2.Add(new Product() { ImageUrl= "http://www.saabturboclub.com/wp-content/uploads/2017/02/Swish.png", Id = 9, Name = "Kassakopplad Stathmos butikvåg", Price = 99.00m, Description= "Vägning av vara med Stathmos butiksvåg. Markera dina varor för vägning. När du säljer varan hämtas vikten direkt från vågen och läggs in som antal kg på kvittot.", IsFactualCost=false });
            products2.Add(new Product() { Id = 10, Name = "Vikt eller pris från EAN streckkod", Price = 79.0m, Description= "Har du en butiksvåg som skriver ut streckkodsetiketter så kan du läsa av vikten eller priset i streckkoden i kassan. Sätt etiketten på paketet i charkdisken efter vägning och kassören kan sen enkelt skanna av streckkoden och får då upp rätt vara och vikt eller pris som streckkoden anger.", IsFactualCost=false });
            products2.Add(new Product() { Id = 11, Name = "Paketvara", Price = 29.00m, Description= "Köp Aftonbladet och bilagan och få dem till ett lägre pris. På en ny flik på varor anger du vilken vara du vill para ihop aktuell vara med och det pris som gäller om kunden köper båda varorna.", IsFactualCost=false });
            products2.Add(new Product() { Id = 12, Name = "Skrivare 3 ",Description = "Bra att ha sak", Price = 420.50m });

            var products3 = new List<Product>();
            products3.Add(new Product() { Id = 13, Name = "Klarna Checkout", Price=199.00m ,Description= "Låt kunden betala med Klarna. Du anger kundens telefonnummer i kassan och kunden slutför köpet direkt i mobilen. Enklare och snabbare kan det inte bli!", IsFactualCost=false});
            products3.Add(new Product() { Id = 14, Name = "Visma Business", Price=499.00m, Description = "Med integration mot Visma Business får du alla kunder, artiklar och priser överförda till kassan. I realtid som du säljer mot kontantkvitto skapas en order i Visma som kan frisläppas och bokföras. Du får också möjlighet i kassan att välja betalsätt faktura, märka leveransen och göra ID kontroll samt skriva ut följesedlar där en order skapas i Visma som frisläpps och ligger kvar för fakturering. Du kan självklart märka all försäljning mot en specifik lagerplats och organisationsenhet.", IsFactualCost = false });
            products3.Add(new Product() { Id = 15, Name = "Microsoft Dynamics NAV", Price=499.00m, Description = "Med en integration till Microsoft Dynamics NAV synkroniseras alla artiklar, priser och kunder mot ditt lagerställe för butikens lagerställe. Kontanta kassakvitton redovisas i NAV som försäljningsfakturor där betalningar med kontant, kort och presentkort konteras bort direkt på fakturan. I kassan kan du hämta upp en försäljningsorder, sälja mer eller mindre och låta kunden betala kontant eller kort. Du kan också välja att leverera varorna i kassan mot en följesedel där en försäljningsorder skapas i NAV. Du kan till och med i kassan skapa en orderbekräftelse till kunden om varorna skall levereras vid ett senare tillfälle.", IsFactualCost = false });
            products3.Add(new Product() { Id = 16, Name = "Fortnox", Price=249.00m, Description = "Med integration mot Fortnox uppdateras alla artiklar och priser i kassan. Dina kvitton bokförs i Fortnox allt efter som du säljer där verifikatet innehåller detaljerad information om vad du har sålt. Lagret i Fortnox uppdateras såklart så du som har en webbshop ansluten till din Fortnox kan känna dig trygg med att lagerantalet på webben stämmer.", IsFactualCost = false });
            products3.Add(new Product() { Id = 17, Name = "Swish Handel", Price = 100.00m , Description = "Swish Handel är en i kassan integrerad tjänst på samma sätt som integrerad kortterminal (Swish Företag är som en fristående kortterminal). Du knappar bara in kundens mobiltelefonnummer och kunden slutför köpet i sin mobil. Startkostnad 499kr där vi hjälper dig ta ut certifikat från Bankgirot och testkör. Transaktionskostnaden är 1kr per betalning över 100 betalningar per månad.", IsFactualCost = false });
            products3.Add(new Product() { Id = 18, Name = "Visma.net Financials", Price =249.00m , Description = "Med en integration till Financials synkroniseras alla artiklar, kunder och bokföringskonton. Försäljningen förs i realtid över till Financials som färdigkonterade verifikat. Du kan också leverera ut varor i kassan mot följesedel för en befintlig kund och skapa en försäljningsorder som du senare fakturerar i Financials.", IsFactualCost = false });

            var products4 = new List<Product>();
            {
                products4.Add(new Product() {Id=19, Name="Kvittar digitala kvitton", Price=0.00m, Description= "Erbjud dina kunder framtiden idag! Kvittar, sparar och arkiverar dina kunders kvitton – digitalt hela vägen från din butik till kunden! Kunden slipper papperskvitton, har alla garantier på ett ställe, inga fler oläsliga papperslappar, snabbare reseräkning, effektivare ekonomihantering. Du får märken och flyers som visar att du är ansluten till Kvittar.", IsFactualCost=false });
                products4.Add(new Product() {Id=20, Name="Digitala kvtton & Lojalitetsystem", Price=00.00m, Description= "Hjälp dina kunder att skicka sina kvitton till himlen. Gör livet enklare för dina kunder, och få en spännande, ny kanal för kundservice, försäljning och lojalitetsbearbetning på samma gång.", IsFactualCost=false });
            }


            var products5 = new List<Product>();
            {
                products5.Add(new Product() { Id = 21, Name = "Yomani kortterminal", Price = 0.00m, Description = "Hjälp dina kunder att skicka sina kvitton till himlen. Gör livet enklare för dina kunder, och få en spännande, ny kanal för kundservice, försäljning och lojalitetsbearbetning på samma gång.", IsFactualCost = false });
                products5.Add(new Product() { Id = 22, Name = "Nets betalkortsterminal", Price = 175.00m, Description = "Med en intergread betalkortsterminal har du som användare full kontroll och ser det användaren ser i kortterminalen.Du behöver bara en skrivare, utskrift av kortköpet sker på kundens butikskvitto.Felslag mellan kassa och kortterminal är ett minne blott!", IsFactualCost = false });
                products5.Add(new Product() { Id=23, Name= "Bambora betalkortsterminal", Price=150.00m, Description= "kundens butikskvitto.Felslag mellan kassa och kortterminal är ett minne blott!", IsFactualCost=false });
            }

            var products6 = new List<Product>();
            {
                products6.Add(new Product() {Id=24, Name="Företagsnamn på varugrupp", Price=49.00m,Description= "Säljer du olika verksamheter i samma butik. Med det här tillägget skrivs ett valfritt företagsnamn överst på kvittot om en vara på kvittot tillhör en specifik varugrupp.", IsFactualCost=false });
                products6.Add(new Product() {Id=25, Name="Skapa egna EAN13 streckkoder", Price=29.00m, Description= "Med ett högerklick på streckodsrutan kan du skapa egna streckkodsnummer. Du har också en enkel inställning för det leverantörsnummer du erhåller av GS1.", IsFactualCost=false });
                products6.Add(new Product() {Id=26, Name="Parkera kvitto", Price=29.00m, Description= "Du kan med ett knapptryck enkelt parkera ett pågående kvitto och senare hämta upp det via kvittolistan där en parkeringssymbol gör det lätt att hitta kvittot.", IsFactualCost=false });
                products6.Add(new Product() {Id= 27, Name= "Bilder på dina varor", Price=29.00m, Description= "Spara en bild på varan. Pefekt för dig som säljer begagnat! Du ser även en miniatyrbild i listan och kan snabbt få en överblick över vilka varor som har bilder.", IsFactualCost=false });
                products6.Add(new Product() {Id=28, Name="Takeaway", Price=79.00m, Description= "Med en standardknapp kan du enkelt ändra varorna på kvittot till rätt moms för takeaway. Du anger momssats och bokföringskonto på respektive varugrupp. Tillägget ingår även i Restaurang à la carte tillägget.", IsFactualCost=false });
                products6.Add(new Product() {Id=29, Name="Lunchbong", Price=49.00m, Description= "Säljer du lucher och behöver du skriva ut en bong i köket är det här tillägget rätt för dig. Markera på varan att bong skall skrivas ut så skapas en bong per kvitto efter betalning.", IsFactualCost=false });
            }

            var products7 = new List<Product>();
            {
                products7.Add(new Product() {Id=30, Name="Företagsval på användare", Price=79.00m, Description= "Har du flera företag som använder samma kassa byts företag, med varor och knappar, allteftersom du klickar på de olika användare du har i verktygsfältet. Kräver kontrollenhet CleanCash MultiUser Typ CF.", IsFactualCost=false });
                products7.Add(new Product() {Id=31, Name="Utökad statistik", Price=79.00m, Description= "Tillhör du dem som vill vända och vrida på siffror? Med det här tillägget får du ytterligare val på fliken statistik och du kan se försäljningen inkl moms, varuvärde, täckningsbidrag, antal kunder per dag, antal kvitton per timme mm.", IsFactualCost=false});
                products7.Add(new Product() {Id=32, Name="Saldo i mobilen", Price=100.00m, Description= "Se butikens saldo i realtid från din mobil var du än befinner dig. Hämta ner appen JobOffice Saldo från iPhone AppStore eller Google Play (endast inom Sverige). Har du flera butiker visas dessa i appen per gatuadress som du har angett i kassan.", IsFactualCost=false});
                products7.Add(new Product() {Id=33, Name="Enkelt kundregister", Price=99.00m, Description= "Med kundregister får du en egen flik för kunder där du kan lägga upp och hantera dina kunder med adress och kontaktinformation tillsammans med en bild. Tillägget ger dig också möjlighet att skicka SMS till en eller flera kunder samtidigt.", IsFactualCost=false });
                products7.Add(new Product() {Id=34, Name="Medlemshantering", Price=26.00m, Description= "Med det här tillägget får du ytterligare en flik på kundbilden där du har fält för medlemsinformation att knyta till din kund. Kräver tillägget Enkelt kundregister eller Utökad Visma/E-conomic Integration.", IsFactualCost=true });
                products7.Add(new Product() {Id=35, Name="Behörighetskontroll för kassörer", Price=99.00m, Description= "Har du anställda och extrapersonal som kassörer är det bra att kunna spärra dem från att ändra varor och inställningar eller se statistik och historik. Tillägget ger dig full kontroll på dina kassörer!", IsFactualCost=false });
                products7.Add(new Product() {Id=36, Name="Självskanning & Kiosk", Price=299.00m, Description= "Minska dina köer i kassan genom att låta kunderna själva betala för sig. Du behöver en kassadator med pekskärm och en betalkortsterminal. Använder du skreckkoder väljer du till en streckkodsläsare.", IsFactualCost=false });
            }



            var categories = new List<Category>();
            categories.Add(new Category() { ImageUrl = "card_terminal.png", Products = products, Name = "Extra betalsätt", Id = 1 });
            categories.Add(new Category() { ImageUrl = "receipt_printer.png", IsMultiSelectable = true, Products = products2, Name = "Prishantering", Id = 2 });
            categories.Add(new Category() { ImageUrl = "shopping_basket.png", IsMultiSelectable = true, Products = products3, Name = "Intergration mot affärssystem", Id = 3 });
            categories.Add(new Category() { IsMultiSelectable = true, Products = products4, Name = "Digitala kvitton", Id = 4 });
            categories.Add(new Category() { IsMultiSelectable = true, Products = products5, Name = "Korthantering", Id = 5 });
            categories.Add(new Category() { IsMultiSelectable = true, Products = products6, Name = "Varor och försäljning", Id = 6 });
            categories.Add(new Category() { IsMultiSelectable = true, Products = products7, IsColapsed = true, Name = "Övrigt", Id = 7 });

            var productgroups = new List<Productgroup>();
            {
                productgroups.Add(new Productgroup() { Id = 1, Name = "Enkla produkten", Description = "För dig som vill ha en enkel och kostnadseffektiv lösning!", ImageUrl = "http://genesismerchant.com/gen-cont/uploads/2014/10/Foundry-POS-image-2.jpg", Categories = categories });
                productgroups.Add(new Productgroup() { Id = 2, Name = "Mellan produkten", Description = "För dig som vill ha en enkel och kostnadseffektiv lösning!", ImageUrl = "http://genesismerchant.com/gen-cont/uploads/2014/10/Foundry-POS-image-2.jpg", Categories = categories });
                productgroups.Add(new Productgroup() { Id = 3, Name = "Stora produkten", Description = "För dig som vill ha en enkel och kostnadseffektiv lösning!", ImageUrl = "http://genesismerchant.com/gen-cont/uploads/2014/10/Foundry-POS-image-2.jpg", Categories = categories });
                productgroups.Add(new Productgroup() { Id = 4, Name = "Mega produkten", Description = "För dig som vill ha en enkel och kostnadseffektiv lösning!", ImageUrl = "http://genesismerchant.com/gen-cont/uploads/2014/10/Foundry-POS-image-2.jpg", Categories = categories });
            };
            var productgroup = productgroups.Find(x => x.Id.ToString() == id);
            return Ok(productgroup);
        }
    }
}
