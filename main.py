import os

def main():
    cc = input("Quanti terminali vuoi aprire? ")
    
    ccint = int(cc)

    for i in ccint:
        os.system("cmd.exe")

if __name__ == "__main__":
    main()
