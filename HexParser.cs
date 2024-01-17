class HexParser {
    public HexParser() {
        return;
    }

    /// <summary>
    /// Converte uma sequência hexadecimal em string para seus respectivos valores em decimal.
    /// </summary>
    /// <param name="hex"></param>
    /// <returns>A sequência decimal de cada digito hexadecimal.</returns>
    public void Hex2Decimal(string hex) {
        hex = hex.ToUpper();

        //List<string> hexDecList = new List<string>{}; //Lista de string com os valores decimais dos hexadecimais.

        string reshex = "";

        int highnib = 0x00; //Vai receber o primeiro nibble do valor hexadecimal
        int lownib  = 0x00; //Vai receber o segundo nibble do valor hexadecimal

        //Realiza a conversão.
        for (int i = 0; i < hex.Length; i += 2) {

            int finalhex = 0x00; //Vai receber highnib e lownib e formar o valor hexadecimal 

            //Verifica se os valores estão dentro do range '0' - '9' (highnib e lownib)
            if (hex[i] >= 48 && hex[i] <= 57) {
                highnib = hex[i] - 48;
            }

            if (hex[i + 1] >= 48 && hex[i + 1] <= 57) {
                lownib = hex[i + 1] - 48;
            }

            //Verifica se os valores estão dentro do range 'A' - 'Z' (highnib e lownib)
            if (hex[i] >= 65 && hex[i] <= 90) {
                highnib = hex[i] - 55;
            }

            if (hex[i + 1] >= 65 && hex[i + 1] <= 90) {
                lownib = hex[i + 1] - 55;
            }

            //Realiza a "concatenação" dos nibbles para converter a representação do hexa em string em um hexa real.
            finalhex = (highnib << 4) + lownib;

            reshex += $"{finalhex.ToString()} ";
        }

        Console.WriteLine(reshex);
    }


    /// <summary>
    /// Converte texto em string para uma sequência de valores hexadecimais.
    /// </summary>
    /// <returns>A conversão do texto para uma sequência hexadecimal.</returns>
    public string String2Hex(string str) {
        return "";
    }

    /// <summary>
    /// Converte uma sequência hexadecimal para texto em string.
    /// </summary>
    /// <returns>A conversão da sequência hexadecimal em texto.</returns>
    public string Hex2String(string hex) {
        return "";
    }
    
}