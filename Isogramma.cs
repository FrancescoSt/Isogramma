using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {
  string[] words = word.Split(' '); // Divide la stringa in parole
        bool hasName = false;
        for (int i = 0; i < words.Length; i++) {
            for (int j = i + 1; j < words.Length; j++) {
                if (words[i] == words[j]) {
                    return false; // Restituisce false se due parole sono uguali
                }
            }
            for (int k = 0; k < words[i].Length; k++) {
                for (int l = k + 1; l < words[i].Length; l++) {
                    if (words[i][k] == words[i][l]) {
                        return false; // Restituisce false se ci sono caratteri ripetuti nella parola
                    }
                }
                if (Char.IsUpper(words[i][k])) {
                    return false; // Restituisce false se c'è una lettera maiuscola nella parola
                }
                if (!Char.IsLetter(words[i][k])) {
                    if (hasName) {
                        return false; // Restituisce false se c'è un carattere non-lettera e non c'è un nome nella stringa
                    }
                } else {
                    hasName = true; // Imposta hasName a true se c'è un nome nella stringa
                }
            }
        }
        return hasName; // Restituisce true solo se c'è almeno un nome nella stringa
    }
}
