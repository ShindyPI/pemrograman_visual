# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="pink")
app.geometry("300x400")
app.resizable(False,False)
app.title("perhitungan layang-layang")

# Function Rumus Layang - Layang
def hitung():
    diagonal1 = float(diagonal1_entry.get())
    diagonal2 = float(diagonal2_entry.get())
    sisi1 = float(sisi1_entry.get())
    sisi2 = float(sisi2_entry.get())
    sisi3 = float(sisi3_entry.get())
    sisi4 = float(sisi4_entry.get())
    
    luas = (diagonal1 * diagonal2) / 2
    keliling = sisi1 + sisi2 + sisi3 + sisi4
    
    showinfo("hasil", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
diagonal1_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Layang - Layang")
diagonal1_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label diagonal_1
diagonal1_label = ttk.Label(input_frame, text="Masukkan diagonal 1 :")
diagonal1_label.pack(padx=10, fill="x", expand=True)
# 2. Entry diagonal_1
diagonal1_entry = ttk.Entry(input_frame)
diagonal1_entry.pack(padx=10, fill="x", expand=True)
# 3. Label diagonal_2
diagonal2_label = ttk.Label(input_frame, text="Masukkan diagonal 2 :")
diagonal2_label.pack(padx=10, fill="x", expand=True)
# 4. Entry diagonal_2
diagonal2_entry = ttk.Entry(input_frame)
diagonal2_entry.pack(padx=10, fill="x", expand=True)
# 5. Label sisi_1
sisi1_label = ttk.Label(input_frame, text="Masukkan sisi 1 :")
sisi1_label.pack(padx=10, fill="x", expand=True)
# 6. Entry sisi_1
sisi1_entry = ttk.Entry(input_frame)
sisi1_entry.pack(padx=10, fill="x", expand=True)
# 7. Label sisi_2
sisi2_label = ttk.Label(input_frame, text="Masukkan sisi 2 :")
sisi2_label.pack(padx=10, fill="x", expand=True)
# 8. Entry sisi_2
sisi2_entry = ttk.Entry(input_frame)
sisi2_entry.pack(padx=10, fill="x", expand=True)
# 9. Label sisi_3
sisi3_label = ttk.Label(input_frame, text="Masukkan sisi 3 :")
sisi3_label.pack(padx=10, fill="x", expand=True)
# 10. Entry sisi_3
sisi3_entry = ttk.Entry(input_frame)
sisi3_entry.pack(padx=10, fill="x", expand=True)
# 11. Label sisi_4
sisi4_label = ttk.Label(input_frame, text="Masukkan sisi 4 :")
sisi4_label.pack(padx=10, fill="x", expand=True)
# 12. Entry sisi_4
sisi4_entry = ttk.Entry(input_frame)
sisi4_entry.pack(padx=10, fill="x", expand=True)
# 13. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

