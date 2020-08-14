mov ax, 0
mov bx, 0
c:
    mov cx, 500h
    add cx, bx
    mov ds, cx
    mov bx, ax
    mov cx, 2
    div cx
    mov ax, bx
    mov bx, ds
    sub bx, 500h
    cmp dx, 1
    jz i
        mov [0], ax
        add bx, 1
    i:
    add ax, 1
cmp bx, 10
jz x
jmp c
x:
hlt