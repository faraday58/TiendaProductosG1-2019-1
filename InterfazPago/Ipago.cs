

namespace InterfazPago
{
    public interface Ipago
    {
        float PEfectivo(float preciototal, float efectivo);
        float PTarjeta(float preciototal, string numtarjeta,float saldo, ushort pin, float comision);
    }
}
