# Rubrica
Progettazione di una rubrica

Sviluppare attraverso la OOP un sistema informatico che possa gestire una rubrica telefonica che contiene un elenco di contatti.
Ogni contatto ha nome, cognome e numero di telefono.
I contatti possono essere di due tipi: lavorativi o personali.
I contatti lavorativi sono caratterizzati dal ruolo del contatto (es. collega, dirigente, responsabile di area, etc.), mentre quelli familiari dalla relazione di parentela o amicizia (es. padre, sorella, amico, etc.)
La rubrica deve poter effettuare e ricevere chiamate da un contatto presente in rubrica (essendo un simulatore la durata sarà calcolata in maniera randomica), ricercare un contatto in rubrica (la ricerca può essere fatta per cognome e restituisce il primo contatto trovato).
La rubrica deve tener traccia delle chiamate in entrata ed in uscita e per ogni chiamata deve memorizzare: contatto, durata e costo.

Il costo viene calcolato con una tariffa diversa in base al tipo di chiamata: personale o lavorativa, quindi è legato al tipo di contatto. 


La rubrica deve poter visualizzare:
- tutte le chiamate
- tutte le chiamate dei contatti personali
- tutte le chiamate dei contatti lavorativi
le lista deve essere visualizzata in ordine di esecuzione/ricezione delle chiamate.
Inoltre deve essere possibile avere:
- la chiamata più lunga in assoluto
- il contatto più frequentemente contattato (sia in entrata e uscita).


La rubrica deve avere un'unica lista per le chiamate ed una unica lista per i contatti, utilizzare il concetto di ereditarietà per distinguere le varie tipologie di contatti.
Implementare le interfacce e metodi necessari per poter confrontare gli oggetti e scorrere le liste. 
