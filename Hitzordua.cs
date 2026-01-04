using System;

namespace Programazioa;

class Hitzordua
{
    public string bezeroa;
    public string zerbitzua;
    public string data;
    public int prezioa;

    public Hitzordua(string bezeroa, string zerbitzua, string data, int prezioa)
    {
        this.bezeroa = bezeroa;
        this.zerbitzua = zerbitzua;
        this.data = data;
        this.prezioa = prezioa;
    }

    public Hitzordua()
    {
        this.bezeroa = "";
        this.zerbitzua = "";
        this.data = "";
        this.prezioa = 0;
    }
}
