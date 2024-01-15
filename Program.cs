namespace hex_parser;
class Program
{
    static void Main(string[] args)
    {
        HexParser hxp = new HexParser();

        hxp.Hex2Decimal("4F6C612C206D756E646F21"); //"Ola, mundo!" em uma sequencia hexadecimal. Retorna:
                                                   //"79 108 97 32 109 117 110 100 111"
    }
}
