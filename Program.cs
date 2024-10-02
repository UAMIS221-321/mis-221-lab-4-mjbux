// See https://aka.ms/new-console-template for more information
//main
PlainPizza();
Console.WriteLine();
CheesePizza();
Console.WriteLine();
PepPizza();
//end main
static void PlainPizza(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);
for ( int i = 0; i<=number;i++){
    Console.Write("*");
    for (int j = number - i; j > 0; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
  } 
}
static void CheesePizza(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);
for ( int i = 0; i<=number;i++){
    for (int j = number - i; j > 0; j--){
        if( i == 0){
            Console.Write("*");
        }
        else{
            if(j != number && j != 1){
            Console.Write("#");
         }
        else{
            Console.Write("*");
        }
     }
    }
    Console.WriteLine();
    if(i != number){
        Console.Write("*");
  } 
    }
 }
static void PepPizza(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);
for ( int i = 0; i<=number;i++){
    int pepporoni = rnd.Next(1,7);
    for (int j = number - i; j > 0; j--){
        if(i ==0){
            Console.Write("*");
        }
        else{
            if(j != number && j != 1){
                if(j != pepporoni){
                Console.Write("#");
                }
                else{
                Console.Write("[]");
                }
            } 
            else{
                Console.Write("*");
            }
        }
    }
    Console.WriteLine();
    if(i != number){
        Console.Write("*");
  } 
 }
}
Console.WriteLine();