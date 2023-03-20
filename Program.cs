using System;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime;

public class Program
{
    private static void Main(string[] args)
    {
        int selecionado = 67;
        Fibo listaFib = new Fibo(selecionado);
        Console.WriteLine($"Sequência próxima do número selecionado: {listaFib.ToString()}. O número selecionado {selecionado} {listaFib.selecionadoNaLista()} na lista!");
    }

}

public class Fibo{
    private int selecionado;
    private List<int> seq;

    public string selecionadoNaLista(){
        if(seq.Contains(this.selecionado)){
            return "ESTÁ";
        }else{
            return "NÃO ESTÁ";
        }
    }

    public Fibo(int num){
        selecionado = num;
        int curr = 0;
        int prev = 0;
        List<int> seq = new List<int>();
        while(curr<num){
            seq.Add(curr+prev);
            if (curr==0)
            {
                curr++;
                continue;
            }else if(curr==1&&prev==0){
                seq.Add(curr);
                prev=curr;
            }else{
                prev = curr;
            }
            curr=seq.Max();
        }
        this.seq=seq;
    }

    public override string ToString()
    {
        string listStr="";
        for(int i=0;i<this.seq.Count;i++){
            listStr+=this.seq[i].ToString()+", ";
        }
        return listStr.Remove(listStr.Length-2);
    }
}