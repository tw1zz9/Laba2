using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class BetterString
    {
        public string Data { get; set; }

        public BetterString() => Data = "";
        public BetterString(string data) => Data = data;

        // Операторы преоразования типов (явный и неявный)
        public static implicit operator BetterString(string data)
            => new BetterString(data);

        public static explicit operator string(BetterString bs)
            => bs.Data;

        // Парные операторы сравнения строк по длине
        public static bool operator <(BetterString a, BetterString b) => a.Data.Length < b.Data.Length;
        public static bool operator >(BetterString a, BetterString b) => a.Data.Length > b.Data.Length;

        // Оператор +, добавляющий число к строке с расстоянием между ними в один пробел
        public static BetterString operator +(BetterString a, int b)
        {
            a.Data += $" {b}";
            return a;
        }

        // Оператор декремента, удаляющий последний символ в строке
        public static BetterString operator --(BetterString a)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (var i = 0; i < a.Data.Length - 1; i++) stringBuilder.Append(a.Data[i]);
            a.Data = stringBuilder.ToString();
            return a;
        }

        // Опертатор умножения, который переписывает строку так, чтобы в ней были символы такие же, как и newCh
        public static BetterString operator *(BetterString a, char newCh)
        {
            StringBuilder newStr = new StringBuilder();
            for (var i = 0; i < a.Data.Length; i++)
                newStr.Append(newCh);
            a.Data = newStr.ToString();
            return a;
        }

        public override string ToString() => Data;
    }

    public static class ExtendedString
    {
        // Метод расширения для подтверждения о наличии символов в строке
        public static bool IsThere(this string str, params char[] ch)
        {
            foreach (var expSymbol in ch)
            {
                foreach (var val in str)
                    if (val == expSymbol) return true;
            }
            return false;
        }
        
        // Метод расширения для переписи строки без знаков препинания
        public static string DeletePunctuationMarks(this string str)
        {
            return string.IsNullOrEmpty(str) ? 
                str : 
                new string(str.Where(c => !char.IsPunctuation(c)).ToArray());
        }
    }
}
