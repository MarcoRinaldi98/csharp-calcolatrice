using csharp_calcolatrice;
// definisco una variabile che conterrà la somma di due numeri
int somma1 = CalcoliHelper.CalcolaSommaNumeri(10, 20);
Console.WriteLine(somma1);
// definisco una variabile che conterrà la somma di due numeri con la virgola
double somma2 = CalcoliHelper.CalcolaSommaNumeriDouble(10.20, 25.40);
Console.WriteLine(somma2);
// definisco una variabile che conterrà la differenza tra due numeri
int differenza1 = CalcoliHelper.DifferenzaNumeri(10, 20);
Console.WriteLine(differenza1);
// definisco una variabile che conterrà la differenza tra due numeri con la virgola
double differenza2 = CalcoliHelper.DifferenzaNumeriDouble(14.90, 8.60);
Console.WriteLine(differenza2);
// definisco una variabile che conterrà la moltiplicazione di due numeri
int moltiplicazione1 = CalcoliHelper.MoltiplicazioneNumeri(10, 20);
Console.WriteLine(moltiplicazione1);
// definisco una variabile che conterrà la moltiplicazione di due numeri con la virgola
double moltiplicazione2 = CalcoliHelper.MoltiplicazioneNumeriDouble(4.50, 9.30);
Console.WriteLine(moltiplicazione2);
// definisco una variabile che conterrà il valore assoluto del numero passato
int valoreAssoluto1 = CalcoliHelper.ValoreAssolutoNumero(-10);
Console.WriteLine(valoreAssoluto1);
// definisco una variabile che conterrà il valore assoluto del numero con la virgola passato
double valoreAssoluto2 = CalcoliHelper.ValoreAssolutoNumeroDouble(5.50);
Console.WriteLine(valoreAssoluto2);
// definisco una variabile che conterrà il numero minimo tra due numeri
int minimo1 = CalcoliHelper.NumeroMinimo(1, 2);
Console.WriteLine(minimo1);
// definisco una variabile che conterrà il numero minimo tra due numeri con la virgola
double minimo2 = CalcoliHelper.NumeroMinimoDouble(1.4, 1.7);
Console.WriteLine(minimo2);
// definisco una variabile che conterrà il numero massimo tra due numeri
int massimo1 = CalcoliHelper.NumeroMassimo(1, 2);
Console.WriteLine(massimo1);
// definisco una variabile che conterrà il numero massimo tra due numeri con la virgola
double massimo2 = CalcoliHelper.NumeroMassimoDouble(1.4, 1.7);
Console.WriteLine(massimo2);