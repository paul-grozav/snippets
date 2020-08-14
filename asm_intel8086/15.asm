;Un exemplu simplu de a te plimba prin o matrice si a pune valoarea 10h la fiecare pozitie

mov cx, 4; numarul de linii
linie:

	;in interiorul unei linii va trebui sa ma plimb la fiecare coloana
	;adica pentru fiecare rand am de completat 4 celule/pozitii ...
	;codul de aici din eticheta "linie" se executa pentru fiecare linie
	;deci ce vreau sa se intample pentru o linie voi scrie aici
	;... Pentru o linie eu mai am nevoie de un loop pentru a ma plimba pe pozitile de pe acea linie
	;dar al doilea loop care vreau sa il folosesc va lucra tot cu variabila cx ... si primul loop are nevoie de cx
	;cx-ul de la primul loop reprezinta numarul liniei la care sunt.
	;Dar pentru ca am nevoie de cx in alta parte voi pune temporar numarul liniei(cx) in bx
	mov bx, cx; bx = cx ... asta imi elibereaza cx-ul ... pot sa il "sterg"/pierd ca am in bx valoarea 
	
	;acum voi incepe al 2-lea loop care se plimba pe coloane ...
	mov cx, 4; numarul de coloane
	coloana:
	
		;codul de aici se repeta de 4 ori pentru fiecare linie ...cum sunt 4 linii se repeta de 16 ori... 
		;acest cod(din interiorul etichetei "coloana") se executa pentru fiecare celula din matrice
		;bx reprezinta numarul de linie(care initial era in cx) si acum cx reprezinta numarul coloanei din matrice
		;desigur ca nu vom completa matricea de la 0h:0h ci vom completa de la coloana 501h 
		;altfel spus: Coltul din stanga sus al matricii va fi la 501h:1h

		;setam DS-ul pentru coloana		
		mov ax, 500h; ax = 500h
		add ax, cx; ax = 500h + cx ... adica la 500h mai adaug numarul coloanei din matrice (4, 3, 2 sau 1)
		mov ds, ax; ds = 500h + cx
		
		mov [bx], 10h; pune la coloana specificata si randul/linia curenta(bx) valoarea 10h
	
	loop coloana;pentru fiecare coloana din cele 4
	
	;acum cand am terminat treaba cu al 2-lea loop ... am terminat si cu cx-ul
	;deci pot sa pun in cx din nou numarul liniei(randului) pentru ca sa nu se incurce loop-ul care e responsabil cu linile
	mov cx, bx; cx = bx ... am pus din ax inapoi in cx (pentru ca in bx am pus mai devreme numarul liniei)

loop linie;repeta linia de 4 ori. Pentru fiecare din cele 4 linii
hlt