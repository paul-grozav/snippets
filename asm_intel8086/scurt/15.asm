mov cx, 4
l:
    mov ax, cx
    mov cx, 4
    c:
        mov bx, 500h
        add bx, cx
        mov ds, bx
        mov bx, ax
        mov [bx], 10h
    loop c
    mov cx, ax
loop l