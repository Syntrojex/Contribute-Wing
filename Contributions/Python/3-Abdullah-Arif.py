import tkinter as tk
from tkinter import simpledialog, messagebox

CELL = 60
MARGIN = 30
DOT = 5

root = tk.Tk()
root.title("Dots and Boxes")
root.withdraw()

def ask_size():
    r = simpledialog.askinteger("Rows", "Number of rows:", initialvalue=4, minvalue=1, maxvalue=15)
    c = simpledialog.askinteger("Columns", "Number of columns:", initialvalue=4, minvalue=1, maxvalue=15)
    return (r or 4, c or 4)

rows, cols = ask_size()
root.deiconify()

canvas = tk.Canvas(root, bg="white")
canvas.pack()
info = tk.Label(root, font=("Arial", 13))
info.pack(pady=4)

turn = "red"
scores = {"red": 0, "blue": 0}
hlines, vlines, boxes = {}, {}, {}
hline_owner, vline_owner, box_owner = {}, {}, {}

def dot_xy(r, c):
    return MARGIN + c * CELL, MARGIN + r * CELL

def update_info():
    made = scores["red"] + scores["blue"]
    info.config(text=f"Turn: {turn.upper()}   |   Red: {scores['red']}   Blue: {scores['blue']}"
                      f"   |   Boxes made: {made}/{rows*cols}")

def box_complete(r, c):
    return (hline_owner.get((r, c)) and hline_owner.get((r + 1, c))
            and vline_owner.get((r, c)) and vline_owner.get((r, c + 1)))

def claim_box(r, c):
    box_owner[(r, c)] = turn
    scores[turn] += 1
    color = "#ffb3b3" if turn == "red" else "#b3d1ff"
    canvas.itemconfig(boxes[(r, c)], fill=color)

def after_move(got_box):
    global turn
    if len(box_owner) == rows * cols:
        update_info()
        end_game()
        return
    if not got_box:
        turn = "blue" if turn == "red" else "red"
    update_info()

def click_hline(r, c):
    if hline_owner.get((r, c)):
        return
    hline_owner[(r, c)] = turn
    canvas.itemconfig(hlines[(r, c)], fill=turn, width=5)
    got = False
    if r - 1 >= 0 and box_complete(r - 1, c):
        claim_box(r - 1, c); got = True
    if r < rows and box_complete(r, c):
        claim_box(r, c); got = True
    after_move(got)

def click_vline(r, c):
    if vline_owner.get((r, c)):
        return
    vline_owner[(r, c)] = turn
    canvas.itemconfig(vlines[(r, c)], fill=turn, width=5)
    got = False
    if c - 1 >= 0 and box_complete(r, c - 1):
        claim_box(r, c - 1); got = True
    if c < cols and box_complete(r, c):
        claim_box(r, c); got = True
    after_move(got)

def end_game():
    if scores["red"] > scores["blue"]:
        msg = "Red wins!"
    elif scores["blue"] > scores["red"]:
        msg = "Blue wins!"
    else:
        msg = "It's a draw!"
    messagebox.showinfo("Game Over", msg)

def build_board():
    canvas.delete("all")
    hlines.clear(); vlines.clear(); boxes.clear()
    canvas.config(width=MARGIN * 2 + cols * CELL, height=MARGIN * 2 + rows * CELL)

    for r in range(rows):
        for c in range(cols):
            x1, y1 = dot_xy(r, c)
            x2, y2 = dot_xy(r + 1, c + 1)
            boxes[(r, c)] = canvas.create_rectangle(x1, y1, x2, y2, fill="white", outline="")

    for r in range(rows + 1):
        for c in range(cols):
            x1, y1 = dot_xy(r, c)
            x2, y2 = dot_xy(r, c + 1)
            lid = canvas.create_line(x1, y1, x2, y2, fill="lightgray", width=4)
            hlines[(r, c)] = lid
            canvas.tag_bind(lid, "<Button-1>", lambda e, r=r, c=c: click_hline(r, c))

    for r in range(rows):
        for c in range(cols + 1):
            x1, y1 = dot_xy(r, c)
            x2, y2 = dot_xy(r + 1, c)
            lid = canvas.create_line(x1, y1, x2, y2, fill="lightgray", width=4)
            vlines[(r, c)] = lid
            canvas.tag_bind(lid, "<Button-1>", lambda e, r=r, c=c: click_vline(r, c))

    for r in range(rows + 1):
        for c in range(cols + 1):
            x, y = dot_xy(r, c)
            canvas.create_oval(x - DOT, y - DOT, x + DOT, y + DOT, fill="black")

def new_game():
    global rows, cols, turn, scores
    rc = ask_size()
    rows, cols = rc
    turn = "red"
    scores = {"red": 0, "blue": 0}
    hline_owner.clear(); vline_owner.clear(); box_owner.clear()
    build_board()
    update_info()

tk.Button(root, text="New Game", command=new_game).pack(pady=4)

build_board()
update_info()
root.mainloop()
