;Fie 2 vectori a si b ambii de aceeasi lunime n(n este ales de noi)
;pentru a schimba valorile vectorilor intre ei vom aplica regula paharelor
;a[i] merge in -> x .... b[i] merge in -> a[i] .... x merge in -> b[i] ... deci x este paharul
;x = a[i] .... a[i] = b[i] .... b[i] = x ... x nu va fi un vector ci unul dintre registrii

;Dar mai intai sa cream vectorii de la 501h pana la 50Ah adica de 10 "celule" il latime
;Fiecare vector va fi pe un rand. primul pe randul 0h iar al doilea pe randul 2h

;crearea primului vector
mov ax, 501h
mov ds, ax
mov [0], 8

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




;crearea celui de-al doilea vector
mov ax, 501h
mov ds, ax
mov [2], 5

mov ax, 502h
mov ds, ax
mov [2], 1

mov ax, 503h
mov ds, ax
mov [2], 2

mov ax, 504h
mov ds, ax
mov [2], 8

mov ax, 505h
mov ds, ax
mov [2], 4

mov ax, 506h
mov ds, ax
mov [2], 7

mov ax, 507h
mov ds, ax
mov [2], 2

mov ax, 508h
mov ds, ax
mov [2], 6

mov ax, 509h
mov ds, ax
mov [2], 2

mov ax, 50Ah;Atentie! in baza 16 adica Hexa(h) cifra 10 este A .. asa ca dupa 509 urmeaza 50A :)
mov ds, ax
mov [2], 9




;-----------DE AICI DEFAPT INCEPE PROGRAMUL--------------
;acum ca avem vectorii ne vom "plimba" de la 1 la n(n este 10 pentru ca am facut vectori de 10 "celule" latime)
mov cx, 10
schimbaValorile:

	;valorile care le vom schimba se afla pe aceeasi coloana pentru ca vectorii sunt unul sub altul
	;Acesta este un caz mai usor ... am facut noi vectorii dar puteau fi dati aiurea, sa nu fie unu sub altu
	;deci va trebui sa schimbam valorile intre 500+cx:0 cu 500+cx:2
	;unde 500 reprezinta inceputul vectorului si cx al catelea element din vector
	;mai intai sa setam DS-ul (numarul coloanei)
	mov ax, 500h
	add ax, cx
	mov ds, ax; ds = 500+cx
	
	;pentru a face aceasta schimbare vom folosi un pahar ... spre exemplu ax ...
	mov ax, [0]; pune in ax elementul de pe randul 0
	;--URMATOAREA LINIE VA DA EROARE ... va trebui sa facem putin altfel
	;mov [0],[2]; pune pe randul 0 elementul de pe randul 2
	mov bx, [2]; pune in bx elementul de pe randul 2
	mov [0], bx; pune pe randul 0 elementul din bx(adica cel care era initial pe randul 2)
	mov [2], ax; pune pe randul 2 elementul din ax (adica cel care a fost initial pe randul 0)
	
	;ATAT ! :)	

loop schimbaValorile
hlt; atentie daca puneti vectorii pe linia 0 si pe linia 1 ... cand veti citi in ax elementul de pe linia 0
;veti citi valori incorecte:) incercati sa descoperiti de ce ... (indiciu: care e diferenta dintre AX si AL?)