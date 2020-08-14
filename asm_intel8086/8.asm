;desi am putea sa punem in memorie direct numerele 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 presupunem ca enuntul se referea la ideea de a cauta acele numere
;vom tine minte in bx numarul de numere impare gasite (initial 0)
;atat timp cat bx != 10 se verifica numarul urmator
;in ax vom tine minte numarul curent(la care suntem - pe care il verificam daca este impar sau par)
;daca div 2 genereaza un dx=1 atunci numarul este impar si il vom pune in memorie la adresa 500+bx si bx va creste cu 1

mov ax, 0; numarul initial pe care il verific.
mov bx, 0; numarul de numere impare gasite
verificaNumarulUrmator:

	;aici trebuie sa verific daca numarul este impar
	;in caz afirmativ sa il pun in memorie la adresa 500+bx si sa cresc apoi bx-ul cu o unitate
	
	;pentru a verifica daca numarul ax este impar va fi nevoie sa impartim la 2
	;dar impartirea la 2 va pune catul in ax ceea ce inseamna ca valoarea lui ax se va pierde
	;pentru a nu pierde valoarea lui ax o vom pune pe aceasta in cx
	mov cx, ax; cx = ax ... ca sa nu pierdem ax-ul in urma impartirii la 2
	
	;pentru ca nu putem imparti la 2 scriind div 2
	;si pentru ca nu putem imparti la dx=2 (impartirea se poate face cat timp dx e zero)
	;va trebui sa punem 2-ul in alta variabila, nu in dx
	;dar pentru ca alte variabile nu mai sunt disponibile va trebui sa complicam putin(ax, bx, cx, dx ocupate)
	;----------------------------------------------------------------------
	
	;avand in vedere ca numarul(daca este impar) va trebui scris in memorie
	;vom pune in ds(numarul coloanei) valoarea 500+bx h. Astfel din ds vom putea deduce pe bx. bx fiind bx = ds-500h
	mov dx, 500h
	add dx, bx
	mov ds, dx; punem in ds valoarea 500+bx h. Acest lucru ne elibereaza variabila bx

	mov dx, 0; inainte de imparitre va trebui sa setam dx=0 pentru a putea face impartirea	
	mov bx, 2
	div bx; impartim pe ax(numarul curent) la bx=2 pentru a afla restul(dx) care daca e 0 inseamna ca numarul ax e par
	
	;acum ca am folosit bx-ul la imparitre va trebui sa punem in bx din nou valoarea initiala bx = ds-500h
	mov bx, ds; bx = ds
	sub bx, 500h; bx = bx - 500h = ds - 500h ... in continuare bx-ul va reprezenta din nou numarul de numere impare gasite
	
	cmp dx, 0; comparam restul cu 0
	jz sari_ePar;daca restul(dx) este egal cu 0 atunci se sare la eticheta mergiMaiDeparte_ePar ... daca dx este diferit de 0(adica e 1) atunci se merge mai departe(fara a sari)
	;daca se ajunge aici inseamna ca ax este impar(nu s-a sarit)
	;ds-ul este setat deja ... trebuie doar sa punem pe (fostul) ax in memorie
	;dar in urma impartirii la 2 s-a pierdut ax-ul ... dar l-am salvat in cx
	;deci vom pune cx-ul in memorie la randul 0h
	
	mov [0], cx; punem numarul curent in memorie la randul 0h
	add bx, 1; vom creste numarul de numere impare gasite cu o unitate. pentru ca am mai gasit un numar impar
	
	sari_ePar:
	
	;pentru ca se pierdea valoarea lui ax prin impartire am salvat-o in cx
	mov ax, cx; acum este momentul sa punem inapoi valoarea din cx in ax ... pentru ca ax sa fie(asa cum ar trebui) numarul curent ... si nu catul impartirii

	
add ax, 1; ax = ax + 1 ... dupa ce am verificat pe ax ... il cresc cu o unitate ca sa verific in continuare si pe ax+1
cmp bx, 10
jz exit; daca bx = 10 atunci inseamna ca am gasit toate cele 10 numere si le-am pus in memorie deci se termina programul
jmp verificaNumarulUrmator; daca bx nu este 10(nu am gasit inca 10 numere) ii spun sa mai caute

exit:; aici se termina programul urmeaza doar hlt adica HALT - suspendarea programului
hlt