package Eventos;
import java.util.ArrayList;
import java.util.Scanner;
public class EventoMain {

    public static void main(String[] args) {
        EventoPandemia evento1 = new EventoPandemia();
        evento1.cadastroEvento();
       
        Pessoas p1 = new Pessoas("Maria","Pituba",18);
        Pessoas p2 = new Pessoas("José","Cajazeiras",24);
        Pessoas p3 = new Pessoas("Fernanda","Federação",17);
        Pessoas p4 = new Pessoas("Marcos","Barra",25);
        
        
        ArrayList<Pessoas> pA = new ArrayList<Pessoas>();
        pA.add(p1);
        pA.add(p2);
        pA.add(p3);
        pA.add(p4);

        
    }
    
}
