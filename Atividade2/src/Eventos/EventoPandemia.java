package Eventos;
import java.util.ArrayList;
import java.util.Scanner;

public class EventoPandemia {
    private String nomeEvento;
    private String local;
    private float valor;
    private String tipoValor;
    //array list de pessoas

    public EventoPandemia(String nomeEvento, String local, float valor, String tipoValor) {
        this.nomeEvento = nomeEvento;
        this.local = local;
        this.valor = valor;
        this.tipoValor = tipoValor;
    }

    public EventoPandemia(){}
    public String getNomeEvento() {
        return nomeEvento;
    }

    public void setNomeEvento(String nomeEvento) {
        this.nomeEvento = nomeEvento;
    }

    public String getLocal() {
        return local;
    }

    public void setLocal(String local) {
        this.local = local;
    }

    public float getValor() {
        return valor;
    }

    public void setValor(float valor) {
        this.valor = valor;
    }

    public String getTipoValor() {
        return tipoValor;
    }

    public void setTipoValor(String tipoValor) {
        this.tipoValor = tipoValor;
    }
    
    public void cadastroEvento(){
        Scanner sc = new Scanner(System.in);
            System.out.println("CADASTRO DE EVENTO\n");
            System.out.println("Nome do evento:");
            setNomeEvento(sc.nextLine());
            System.out.println("Local do evento:");
            setLocal(sc.nextLine());
            System.out.println("O evento será pago? Sim ou Não?");
            setTipoValor(sc.nextLine());
            if(getTipoValor().equalsIgnoreCase("Sim")){
                System.out.println("Qual o valor do evento?");
                setValor(sc.nextFloat());
            }else if(getTipoValor().equalsIgnoreCase("Não")){
                setValor(0);
            }else{
                System.out.println("Comando incorreto");
                }
            }
  
 
        
        
        
    
}
