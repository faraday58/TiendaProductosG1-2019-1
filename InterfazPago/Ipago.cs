

namespace InterfazPago
{
    public interface Ipago
    {
        float PEfectivo(float preciototal, float efectivo);
        float PTarjeta(float preciototal, string numtarjeta,float saldo, float comision, string cvv, string fecha);
    }
}
