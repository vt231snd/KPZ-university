class TextDocumentMemento:
    def __init__(self, content):
        self._content = content

    def get_content(self):
        return self._content


class TextDocument:
    def __init__(self):
        self._content = ""

    def write(self, text):
        self._content += text
        print(f"[Document] Додано текст: \"{text}\"")

    def show(self):
        print(f"[Document] Поточний вміст:\n{self._content}")

    def save(self):
        return TextDocumentMemento(self._content)

    def restore(self, memento: TextDocumentMemento):
        self._content = memento.get_content()
        print("[Document] Стан документа відновлено.")


class TextEditor:
    def __init__(self):
        self._document = TextDocument()
        self._history = []

    def type_text(self, text):
        self._document.write(text)

    def save(self):
        memento = self._document.save()
        self._history.append(memento)
        print("[Editor] Стан збережено.")

    def undo(self):
        if not self._history:
            print("[Editor] Немає збереженого стану.")
            return
        memento = self._history.pop()
        self._document.restore(memento)

    def show(self):
        self._document.show()


def main():
    editor = TextEditor()

    editor.type_text("Привіт, це тестовий редактор.\n")
    editor.save()

    editor.type_text("Додаємо другий рядок.\n")
    editor.save()

    editor.type_text("І ще один рядок для перевірки.\n")

    print("\n== Поточний вміст ==")
    editor.show()

    print("\n== Відкат до попереднього стану ==")
    editor.undo()
    editor.show()

    print("\n== Ще один відкат ==")
    editor.undo()
    editor.show()

    print("\n== Спроба відкотити без збережень ==")
    editor.undo()


if __name__ == "__main__":
    main()
