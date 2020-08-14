;cele doua numere cu care facem +, -, *, /
mov ax, 5
mov bx, 2
        
;la 500h:0h vom pune adunarea ax + bx        
add ax, bx; calculez suma ax = ax + bx
mov dx, 500h
mov ds, dx
mov [0], ax; am pus suma ax + bx in memorie la 500h:0h
mov ax, 5; pun in ax valoarea initiala pentru ca s-a pierdut cand am facut add ax, bx ... ax = ax + bx

;la 501h:0h vom pune diferenta ax - bx
sub ax, bx; calculez diferenta ax = ax - bx
mov dx, 501h
mov ds, dx
mov [0], ax; pun in memorie la 501h:0h diferenta ax = ax - bx
mov ax, 5; pentru ca facand diferenta ax = ax - bx s-a perdut valoarea initiala din ax -> o pun la loc ca sa fac calculele in continuare cu acelasi ax care s-a dat la inceput(initial)


;la 502h:0h vom pune produsul ax * bx
mul bx; calculez produsul ax = ax * bx
mov dx, 502h
mov ds, dx
mov [0], ax; pun in memorie(RAM) la adresa 502h:0h produsul ax = ax * bx
mov ax, 5; findca in urma inmultirii s-a schimbat variabila ax ii dau din nou valoarea initiala

;la 503h:0h vom pune catul impartirii lui ax la bx
;la 504h:0h vom pune restul impartirii lui ax la bx
mov dx, 0; dx trebuie setat pe 0 pentru a se putea efectua impartirea
div bx; aceasta comanda pune in ax catul impartirii lui ax la bx si in dx restul impartirii lui ax la bx. Deci trebuie sa salvez in memorie AX(catul) si DX(restul)
mov cx, 503h; atentie! aici folosesc cx pentru a schimba pe ds pentru ca daca as pune 503h in dx s-ar pierde restul impartirii
mov ds, cx
mov [0], ax; pun in memorie la adresa 503h:0h catul impartirii lui ax la bx

mov cx, 504h
mov ds, cx
mov [0], dx; pun in memorie la adresa 504h:0h restul impartirii lui ax la bx


hlt;sfarsitul programului :)