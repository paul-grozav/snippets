;Desigur am putea spune dintr-o privire ca numarul de elemente pare este 2 dar aceasta valoare am obtinut-o noi nu calculatorul :)
;Mai intai sa cream vectorul 1, 3, 6, 7, 9, 0 incepand de la 500h:0h

mov ax, 500h
mov ds, ax
mov [0], 1

mov ax, 501h
mov ds, ax
mov [0], 3

mov ax, 502h
mov ds, ax
mov [0], 6

mov ax, 503h
mov ds, ax
mov [0], 7

mov ax, 504h
mov ds, ax
mov [0], 9

mov ax, 505h
mov ds, ax
mov [0], 0

;va trebui sa tinem minte numarul de numere pare. Pentru asta vom folosi bx
mov bx, 0; initial am gasit 0 numere pare
;acum ne vom plimba prin vector. Vectorul este de la 500h pana la 505h pe randul 0h deci avem 6 valori
mov cx, 6;numarul de elemente din vector este 6
urmatorulElement:

	;cx va lua valori de la 6 in jos pana la 1
	;500h + 6 - 1 = 505h adica elementul de pe pozitia 6
	;500h + 5 - 1 = 504h adica elementul de pe pozitia 5
	;...............................................
	;500h + cx -1 = elementul de pe pozitia cx
	;vom seta deci DS-ul pe 499h + cx
	mov ax, 500h; ax = 500h
	add ax, cx; ax = 500h + cx
	sub ax, 1; ax = 500h + cx - 1
	mov ds, ax;ds = 500h + cx - 1
	
	mov ax, [0]; pune in ax elementul de pe pozitia cx din vector
	
	;trebuie sa stabilim daca ax este par sau nu pentru asta il vom imparti la 2 si vom studia restul(dx)
	;pentru ca voi imparti la bx=2 voi salva mai intai pe bx in cx si cx-ul il voi recupera din ds ... cx = ds-500h+1
	mov cx, bx; cx=bx
	;acum pot imparti la bx=2
	mov bx, 2;pun 2 in bx(bx=2) si impart la bx pentru ca nu pot imparti direct la 2(div 2)
	div bx
	;acum ca am terminat cu bx pot sa pun in el din nou numarul de elemente pare gasite
	mov bx, cx; bx=cx
	
	;daca dx(restul) este 0 atunci numarul este par, daca dx este diferit de 0 (adica 1) atunci numarul este impar
	cmp dx, 1; seteaza ZF=0 daca dx=1 si seteaza ZF=0 daca dx e diferit de 1
	jz eImpar;daca ZF=0 atunci sari mai jos la eticheta "eImpar"
	;daca a ajuns aici inseamna ca ZF nu e 0 deci dx nu e 1 deci dx e 0 deci numarul este par
	add bx, 1; bx = bx+1 pentru ca am mai gasit un numar par
	eImpar:
	;acum pot in sfarsit sa pun in cx valoarea care era initial .. si care reprezinta la al catelea element din vector sunt
	mov cx, ds
	sub cx, 500h; cx = ds - 500h
	add cx, 1; cx = ds - 500h + 1
	

loop urmatorulElement
hlt