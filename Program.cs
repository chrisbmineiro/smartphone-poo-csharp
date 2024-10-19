using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Instanciar objetos e chamar os métodos
Nokia nokia = new Nokia("Nokia", "modelo 1", "123", 64);
Iphone iphone = new Iphone("Iphone", "modelo 1", "123", 64);

nokia.InstalarAplicativo("Duolingo");
iphone.InstalarAplicativo("Duolingo");

nokia.Ligar(123);
iphone.Ligar(123);

nokia.ReceberLigacao(123);
iphone.ReceberLigacao(123);