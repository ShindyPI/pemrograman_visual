from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
import math

class FrmLingkaran:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("220x160")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        # pasang Label
        Label(mainFrame, text='Jarijari:').grid(row=0, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Luas:').grid(row=2, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Keliling:').grid(row=3, column=0,
            sticky=W, padx=5, pady=5)
        
    

        # pasang textbox
        self.txtJarijari = Entry(mainFrame)
        self.txtJarijari.grid(row=0, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=2, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=3, column=1, padx=5, pady=5)


        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
            command=self.onHitung)
        self.btnHitung.grid(row=1, column=1, padx=5, pady=5)


# fungsi untuk menghitung luas dan keliling lingkaran
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
        r= int(self.txtJarijari.get())
        
        luas = math.pi * (r * r)
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(format(luas,'.2f')))

        kel = 2 * math.pi * r
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(format(kel,'.2f')))

    def onKeluar(self, event=None):
    # memberikan perintah menutup aplikasi
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmLingkaran(root, "Program Luas dan Keliling Lingkaran")
    root.mainloop() 