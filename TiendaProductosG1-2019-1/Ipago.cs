

namespace TiendaProductosG1_2019_1
{
    interface Ipago
    {
        float PEfectivo(float preciototal, float efectivo, float cambio);
        float PTarjeta(float preciototal, string numtarjeta,float saldo, ushort pin, float comision);
    }
}
