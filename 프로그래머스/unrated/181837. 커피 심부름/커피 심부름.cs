using System;

public class Solution {
    public int solution(string[] order) {
        int price = 0;
        foreach(string s in order)
        {
            switch(s)
            {
                case "iceamericano":
                case "americanoice":
                case "hotamericano":
                case "americanohot":
                case "americano":
                case "anything":
                    price += 4500;
                    break;
                case "icecafelatte":
                case "cafelatteice":
                case "hotcafelatte":
                case "cafelattehot":
                case "cafelatte":
                    price += 5000;
                    break;
            }
        }
        return price;
    }
}