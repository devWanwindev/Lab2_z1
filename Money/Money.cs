
using System.Formats.Asn1;

namespace Money
{
    internal class Money
    {
        private uint _rubles;
        private byte _kopeks;

        Money(uint rubles, int kopeks)
        {
            this._rubles = rubles;
            
            while (kopeks > 100) {
                kopeks -= 100;
                _rubles += 1;
            }

            this._kopeks = (byte)kopeks;
            
        }

        public void Print()
        {
            Console.WriteLine($"{_rubles} Рублей, {_kopeks} Копеек");
        }
    }
}
