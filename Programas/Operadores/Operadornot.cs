namespace ExemplosFundamentos
{
public static class Operadornot
    {
        public static void MetodoNot()
        {
            bool choveu = true;
            bool estaTarde = true;


        if(!!choveu && !!estaTarde){
            Console.WriteLine("Vou pedalar");}
        else{
            Console.WriteLine("Cancela!");
        }
        } 
    }
}