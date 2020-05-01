using System;

namespace Objektumok
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane1 = new Plane();
            var plane2 = new Plane();

            //1.Azonosíthatóság (azt vizsgálja két objektum referenciája ugyanoda mutat-e)
            if (plane1 == plane2)
            {
                //..
            }

            //2.Állapot: Az objektum lekérdezhető információk halmaza az adott pillanatban (időben változhat)
            //Állapothoz tartozó információk őrzésére két lehetőség van
            //     I. MEZŐ (field) 
            //         //public int Number1;
            //---------------------------------------------------------------------------------------------------
            //     II. TULAJDONSÁG 
            //Elválasztukuk az írást és az olvasást
            //Külön lehet írás, olvasást láthatóságűt is szabályozni
            //public int Number1 {get; set;}

            //Fordító csinál belőle egy ilyet
            //private int _number1; => backing field, ez tartalmazza a property értékét
            //public int number1GET(){
            //    return _number1;
            //}
            //public void number1SET(int number1){
            //   _number1 = number1;
            //}
            //Speciális implementáció a property-nek külön műveletek írás, olvasás
            //Ilyenkor a backing fieldet kézzel kell létrehozni
            //private int _date;
            //public string Date
            //{
            //    set
            //    {
            //        _date = value;
            //    }
            //}
            //---------------------------------------------------------------------------------------------------
            //3.Viselkedés: Függvényeken keresztül lehet szabályozni.
            //public void Show(bool disable)
            //{

            //}
            //---------------------------------------------------------------------------------------------------
            //1.Érték átadása
            //Ha érték típust szertnénk referenciaként átadni, akkor ref kulcsszó
            //pl függvény paraméter ref int valami
            //hívó félen is ki kell írni a ref kulcsszót
            //---------------------------------------------------------------------------------------------------
            //2. out kulcsszó (Csak kifelé ad értéket )
            //Mindenképpeb értéket kell adni az out ként definiált paraméternek afüggvény belsejében
            //Hívó oldalon is ki kell írni az out kulcsszavat
            //int ertek2;                               => hívó oldalon paramétert közelező definiálni
            //plane1.Show(ertek, out ertek2);           => hívásnál

            //public void (int ertek, out int ertek2)   => implementációban
            //{
            //ertek2 = 10; => értékadás
            //}

            //PARAMÉTEREK DEFAULT ÉRTÉK 
            //public void Show(int height=5) Ha egynek adunk onnantól kezdve összes többienk is kell.
            //Alapértelmezett értékkel rendelkező paraméterek elhegyhatóak.
            //panel.Show();= >paraméter nélküli
            //úgy is működik, ha nem adjuk meg össtes paramétert DE így hivatkozunk rá
            //plane1.Show(with: 9, name: "akármi"); => alapértelmezett értékek miatt pl high-ot nem kell megadni

        }
    }
}
