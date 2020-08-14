;mai intai sa cream vectorul de la 501h:0h

mov ax, 501h
mov ds, ax
mov [0h], 1

mov ax, 502h
mov ds, ax
mov [0h], 2

mov ax, 503h
mov ds, ax
mov [0h], 3

mov ax, 504h
mov ds, ax
mov [0h], 4

mov ax, 505h
mov ds, ax
mov [0h], 5

mov ax, 506h
mov ds, ax
mov [0h], 6

mov ax, 507h
mov ds, ax
mov [0h], 7

mov ax, 508h
mov ds, ax
mov [0h], 8


;------- DE AICI INCEPEM SA INMULTIM VECTORUL CU UN NUMAR (ales de noi)--------
mov cx, 8; 8 pentru ca atatea valori are vectorul nostru (are 8 casutze latime)
element:

	;fiecare element va trebui sa fie citit, inmultit cu numarul, si pus la loc
	;pentru ca inmultirea se face la ax vom pune elementul din memorie tocmai in ax
	;apoi vom da mul pentru a fi inmultit si il vom pune la loc
	
	;mai intai sa setam DS-ul
	mov ax, 500h;putem linistiti sa folosim ax-ul pentru a seta DS-ul
	add ax, cx
	mov ds, ax; ds = 500h + cx adica 500h + al catelea element .. se obtine 508h, 507h, ..., 501h pentru ca cx ia valori de la 8 la 1
	
	mov ax, [0h];asa cum spuneam punem elementul din vector in ax (de la coloana DS si randul 0h)
	;urmeaza sa inmultim cu bx=2
	mov bx, 2;bx=2
	mul bx; ax = ax * bx ... adica ax = ax * 2
	;si acum punem valoarea din ax inapoi in vector
	mov [0h], ax; pune valoarea din ax in vector la coloana DS si randul 0h

loop element;pentru fiecare element din vector
hlt