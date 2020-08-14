mov ax, 501h
mov ds, ax
mov [1], 1
mov ax, 501h
mov ds, ax
mov [2], 2
mov ax, 501h
mov ds, ax
mov [3], 3
mov ax, 502h
mov ds, ax
mov [1], 4
mov ax, 502h
mov ds, ax
mov [2], 5
mov ax, 502h
mov ds, ax
mov [3], 6
mov ax, 503h
mov ds, ax
mov [1], 7
mov ax, 503h
mov ds, ax
mov [2], 8
mov ax, 503h
mov ds, ax
mov [3], 9

mov cx, 3
l:
    mov bx, cx
    mov cx, 3
    c:
        mov ax, 500h
        add ax, cx
        mov ds, ax
        mov ax, 0
        mov al, [bx]
        mov dx, 2
        mul dx
        mov [bx], al
    loop c
    mov cx, bx
loop l