mov ax, 500h
mov ds, ax
mov [0], 1
mov ax, 500h
mov ds, ax
mov [1], 2
mov ax, 500h
mov ds, ax
mov [2], 3
mov ax, 501h
mov ds, ax
mov [0], 4
mov ax, 501h
mov ds, ax
mov [1], 5
mov ax, 501h
mov ds, ax
mov [2], 6
mov ax, 502h
mov ds, ax
mov [0], 7
mov ax, 502h
mov ds, ax
mov [1], 8
mov ax, 502h
mov ds, ax
mov [2], 9

mov dx, 0
mov cx, 3
l:
    mov ax, cx
    mov cx, 3
    c:
        cmp ax, cx
        jz e
        jmp i
        e:
            mov bx, 500h
            add bx, cx
            sub bx, 1
            mov ds, bx
            mov bx, ax
            sub bx, 1
            mov bl, [bx]
            add dx, bx
        i:
    loop c
    mov cx, ax
loop l