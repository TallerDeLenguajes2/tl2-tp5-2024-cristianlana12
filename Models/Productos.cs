namespace Models;

class Productos
{
    private int idProducto;
    private string? descripcion;
    private int precio;
    public int IdProducto { get => idProducto; set => idProducto = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Precio { get => precio; set => precio = value; }

    Productos(){
        this.idProducto = -1;
        this.descripcion = string.Empty;
        this.precio = 0;
    }

    Productos(string descripcion, int precio){
        this.idProducto = 0;
        this.descripcion = descripcion;
        this.precio = precio;
    }
    Productos(int idProd, string descripcion, int precio){
        this.idProducto = idProd;
        this.descripcion = descripcion;
        this.precio = precio;
    }
}