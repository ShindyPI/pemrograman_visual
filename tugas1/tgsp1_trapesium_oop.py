from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
\
class FrmTrapesium:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("450x200")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        # pasang Label
        Label(mainFrame, text='Sisi Atas:').grid(row=0, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi Bawah').grid(row=1, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi Miring:').grid(row=0, column=2,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Tinggi:').grid(row=1, column=2,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Luas:').grid(row=4, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Keliling:').grid(row=5, column=0,
            sticky=W, padx=5, pady=5)
        
    

        # pasang textbox
        self.txtSisiA = Entry(mainFrame)
        self.txtSisiA.grid(row=0, column=1, padx=5, pady=5)
        self.txtSisiB = Entry(mainFrame)
        self.txtSisiB.grid(row=1, column=1, padx=5, pady=5)
        self.txtSisiC = Entry(mainFrame)
        self.txtSisiC.grid(row=1, column=4, padx=5, pady=5)
        self.txtSisiD = Entry(mainFrame)
        self.txtSisiD.grid(row=0, column=4, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=4, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=5, column=1, padx=5, pady=5)


        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
            command=self.onHitung)
        self.btnHitung.grid(row=3, column=1, padx=5, pady=5)


# fungsi untuk menghitung luas dan keliling lingkaran
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
    
        alasA= int(self.txtSisiA.get())
        alasB= int(self.txtSisiB.get())
        tinggi= int(self.txtSisiC.get()) 
        sisim= int(self.txtSisiD.get())
        
        luas = 0.5 * ( alasA * alasB) * tinggi
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))

        kel = alasA + alasB + sisim + tinggi
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))

    def onKeluar(self, event=None):
    # memberikan perintah menutup aplikasi
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmTrapesium(root, "Program Luas dan Keliling Trapesium")
    root.mainloop() 