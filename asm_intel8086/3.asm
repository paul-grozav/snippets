;presupunem ca inainte de a rula programul exista in memorie la 500h:0h si 501h:0h doua numere cu care noi vom face produsul(inmultirea)
;pentru a fi siguri ca acolo exista cele doua numere le vom pune chiar noi

mov cx, 500h
mov ds, cx
mov [0], 2; am pus in memorie la 500h:0h numarul 2

mov cx, 501h
mov ds, cx
mov [0], 8; am pus in memorie la 501h:0h numarul 8
;------------ DEFAPT DE AICI AR TREBUI SA INCEAPA PROGRAMUL -------------
;planuim sa punem numarul de la 500h:0h in ax
;numarul de la 501h:0h in bx
;sa facem produsul ax = ax * bx
;sa punem pe ax(adica produsul) la adresa 502h:0h

;citim numarul de la 500h:0h si il punem in ax
mov cx, 500h; cum ax si bx vor fi folosite pentru a stoca numerele folosim cx-ul care e liber
mov ds, cx
mov ax, [0]; pune in ax numarul de la adresa 500h:0h

;citim numarul de la 501h:0h si il punem in bx
mov cx, 501h
mov ds, cx
mov bx, [0]; punem in bx numarul de la adresa 501h:0h

mul bx; calculam produsul ax = ax * bx

;punem produsul(ax) in memorie la adresa 502h:0h
mov cx, 502h
mov ds, cx
mov [0], ax; pune pe ax la adresa 502h:0h in memorie

hlt; sfarsitul programului :)