import os

def main():
    cc = input("Quanti terminali vuoi aprire? ")

    for i in cc:
        os.system("cmd.exe")

if __name__ == "__main__":
    main()
