# Isogramma (versione definitiva)

## Descrizione 
Questo programma, scritto in c#, facendo inserendo una stringa, si va averificare se, la stringa inserita è un isogramma oppure no.

## Codice(senza commenti)
```c#
string[] words = word.Split(' '); 
        bool hasName = false;
        for (int i = 0; i < words.Length; i++) {
            for (int j = i + 1; j < words.Length; j++) {
                if (words[i] == words[j]) {
                    return false; 
                }
            }
            for (int k = 0; k < words[i].Length; k++) {
                for (int l = k + 1; l < words[i].Length; l++) {
                    if (words[i][k] == words[i][l]) {
                        return false; 
                    }
                }
                if (Char.IsUpper(words[i][k])) {
                    return false; 
                }
                if (!Char.IsLetter(words[i][k])) {
                    if (hasName) {
                        return false; 
                    }
                } else {
                    hasName = true; 
                }
            }
        }
        return hasName; 

``` 

## Codice con commenti
```c#
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

``` 
## Divisione in blocchi

* Primo blocco
```c#
 string[] words = word.Split(' '); 
``` 
Il primo blocco di codice divide la stringa "word" in parole sulla base dello spazio bianco, creando un array di stringhe chiamato "words".

* Secondo blocco
```c#
 for (int i = 0; i < words.Length; i++) {
       for (int j = i + 1; j < words.Length; j++) {
           if (words[i] == words[j]) {
               return false; 
           }
       }
       for (int k = 0; k < words[i].Length; k++) {
           for (int l = k + 1; l < words[i].Length; l++) {
               if (words[i][k] == words[i][l]) {
                   return false; 
               }
           }
           if (Char.IsUpper(words[i][k])) {
               return false; 
           }
           if (!Char.IsLetter(words[i][k])) {
               if (hasName) {
                   return false; 
               }
           } else {
               hasName = true; 
           }
       }
   }

``` 
Il secondo blocco di codice è un blocco "for" che itererà su tutte le parole nell'array "words".
Il primo ciclo "for" controlla se ci sono parole ripetute nell'array "words" e restituisce "false" se trova parole uguali.
Il secondo ciclo "for" esamina ogni carattere in ogni parola e restituisce "false" se c'è un carattere maiuscolo nella parola, se ci sono caratteri ripetuti nella parola o se c'è un carattere non-lettera e non c'è un nome nella stringa.
Se viene trovato un nome nella stringa, la variabile "hasName" viene impostata su "true".

* Terzo blocco
```c#
return hasName; 
``` 
Nel terzo ed ultimo blocco di codice restituisce "true" solo se c'è almeno un nome nella stringa, altrimenti restituisce "false".
