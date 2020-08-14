;Altfel spus avem de calculat produsul elementelor impare ale unui vector cu n elemente
;avem nevoie sa stim cat e n (il vom da noi pentru ca nu se da)
;mai avem nevoie de o variabila in care sa facem produsul ... vom folosi ax pentru ca mul face produsul direct in ax

;mai intai de toate trebuie sa ne facem noi vectorul, adica sa punem numere in el (ca sa avem cu ce lucra)
;vom pune elemente in vector incepand de la coloana 501h ... pana la coloana 50Ah ... pe randul 0h
mov ax, 501h; la coloana 501h
mov ds, ax
mov [0], 8; pun elementul 8 ...

mov ax, 502h
mov ds, ax
mov [0], 1

mov ax, 503h
mov ds, ax
mov [0], 0

mov ax, 504h
mov ds, ax
mov [0], 5

mov ax, 505h
mov ds, ax
mov [0], 2

mov ax, 506h
mov ds, ax
mov [0], 1

mov ax, 507h
mov ds, ax
mov [0], 5

mov ax, 508h
mov ds, ax
mov [0], 6

mov ax, 509h
mov ds, ax
mov [0], 1

mov ax, 50Ah;Atentie! in baza 16 adica Hexa(h) cifra 10 este A .. asa ca dupa 509 urmeaza 50A :)
mov ds, ax
mov [0], 5






;----------DE AICI IN JOS INCEPE DEFAPT PROGRAMUL--------------

mov ax, 1;initial produsul este 1
;urmatorul 10 reprezinta dimensiunea vectorului(n). Adica voi citi valoarea de pe pozitia 10 apoi 9, 8, ..., 2, 1
mov cx, 10; voi folosi CX si LOOP pentru a ma plimba prin vector.
citesteDinVector:

	;codul de aici se repeta pentru fiecare element din vector, dar in sens invers incepand de la 10 in jos
	;problema este putin interesanta pentru ca avem de facut (pentru fiecare element) o impartire(la 2 pt a stabili daca e par)
	;si o inmultire(in caz ca e par). Dar dupa cum stim div afecteaza pe ax(punand catul) si mul inmulteste la ax numarul dat
	;deci va trebui sa salvam produsul curent intr-o alta parte pana facem impartirea pentru a nu il pierde
	mov bx, ax; ax reprezinta produsul pana la momentul de fatza. il vom salva in bx => ax e liber
	
	;trebuie sa verificam daca elementul este par. Pentru asta il vom imparti la 2 si vom analiza restul
	;pentru impartire vom folosi div bx dar aceasta comanda imparte pe ax la bx si pune restul in dx
	;deci elementul nostru din vector vreau sa il pun in ax pentru ca div imparte pe ax la ... cine ii spun eu
	
	;dar mai intai voi seta coloana(DS) pentru a citi din memorie. Sa zicem ca citesc de la 501h:0h
	mov ax, 500h; de aici incepe vectorul meu
	add ax, cx; cx-ul reprezita al cate-lea element din vector elementul 10 va fi la pozitia 500+10 h ...
	mov ds, ax; am setat coloana
	;in continuare putem folosi ax-ul pentru a stoca in el elementul din vector
	mov ax, [0];pune in ax elementul de la coloana specificata si linia 0h
	;voi imparti pe ax(elementul curent din vector) la 2
	;in continuare in loc de cx as fi putut folosi bx dar am nevoie de bx pentru ca vreau sa fac suma elementelor pare in el
	mov cx, 2;cx reprezinta la al catelea element din vector sunt.Punand 2 se va pierde aceasta valoare dar o voi afla din ds ... cx = ds-500h
	div cx             
	;pentru ca am terminat treaba cu ax vom pune pe bx(produsul curent) inapoi in ax unde ii este locul
	mov ax, bx; ax = bx
	;acum trebuie sa compar restul impartirii(dx) cu 0 daca sunt egale inseamna ca elementul este par
	cmp dx, 0; seteaza ZF=0 daca dx=0 ... daca dx e diferit de 0 atunci va seta ZF=1
	jz ePar;daca restul impartirii la 2 e 0 atunci elementul e par si nu ne intereseaza...deci o sa sara ceva mai jos la eticheta "ePar"
	;daca a ajuns aici(nu a sarit la "ePar") inseamna ca dx nu e 0 deci e 1 si numarul e impar
	;deci trebuie sa il adaugam la produs.
	;Dar elementul meu care a fost citit mai devreme (in ax) s-a pierdut ... deci il voi citi iarasi din memorie(DS(coloana) e aceeasi)
	mul [0]; inmulteste la ax pe bx elementul de la coloana specificata si linia 0h ... adica elementul nostru impar
	ePar:
	;acum, daca am terminat cu cx-ul trebuie sa pun inapoi in el valoarea initiala ... care ne spune la al catelea element din vector suntem
	mov cx, ds
	sub cx, 500h

loop citesteDinVector; cx = cx-1 ... daca cx e diferit de 0 atunci mergi sus la "citesteDinVector" altfel mergi mai departe
hlt