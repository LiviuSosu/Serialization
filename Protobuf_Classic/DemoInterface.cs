// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: demo-interface.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.Examples.AddressBook {

  /// <summary>Holder for reflection information generated from demo-interface.proto</summary>
  public static partial class DemoInterfaceReflection {

    #region Descriptor
    /// <summary>File descriptor for demo-interface.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DemoInterfaceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRkZW1vLWludGVyZmFjZS5wcm90bxIIdHV0b3JpYWwitAEKBUJvb2tzEicK",
            "BWJvb2tzGAEgAygLMhgudHV0b3JpYWwuQm9va3MuQm9va0luZm8agQEKCEJv",
            "b2tJbmZvEgoKAmlkGAEgASgFEg0KBXRpdGxlGAMgASgJEhEKCXBhZ2VDb3Vu",
            "dBgEIAEoBRIvCgZhdXRob3IYBSABKAsyHy50dXRvcmlhbC5Cb29rcy5Cb29r",
            "SW5mby5BdXRob3IaFgoGQXV0aG9yEgwKBG5hbWUYASABKAlCJ6oCJEdvb2ds",
            "ZS5Qcm90b2J1Zi5FeGFtcGxlcy5BZGRyZXNzQm9va2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Examples.AddressBook.Books), global::Google.Protobuf.Examples.AddressBook.Books.Parser, new[]{ "Books_" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo), global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Parser, new[]{ "Id", "Title", "PageCount", "Author" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Types.Author), global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Types.Author.Parser, new[]{ "Name" }, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Books : pb::IMessage<Books> {
    private static readonly pb::MessageParser<Books> _parser = new pb::MessageParser<Books>(() => new Books());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Books> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.Examples.AddressBook.DemoInterfaceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Books() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Books(Books other) : this() {
      books_ = other.books_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Books Clone() {
      return new Books(this);
    }

    /// <summary>Field number for the "books" field.</summary>
    public const int Books_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo> _repeated_books_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo> books_ = new pbc::RepeatedField<global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo> Books_ {
      get { return books_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Books);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Books other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!books_.Equals(other.books_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= books_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      books_.WriteTo(output, _repeated_books_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += books_.CalculateSize(_repeated_books_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Books other) {
      if (other == null) {
        return;
      }
      books_.Add(other.books_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            books_.AddEntriesFrom(input, _repeated_books_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Books message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class BookInfo : pb::IMessage<BookInfo> {
        private static readonly pb::MessageParser<BookInfo> _parser = new pb::MessageParser<BookInfo>(() => new BookInfo());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<BookInfo> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Protobuf.Examples.AddressBook.Books.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BookInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BookInfo(BookInfo other) : this() {
          id_ = other.id_;
          title_ = other.title_;
          pageCount_ = other.pageCount_;
          author_ = other.author_ != null ? other.author_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BookInfo Clone() {
          return new BookInfo(this);
        }

        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;
        private int id_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Id {
          get { return id_; }
          set {
            id_ = value;
          }
        }

        /// <summary>Field number for the "title" field.</summary>
        public const int TitleFieldNumber = 3;
        private string title_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Title {
          get { return title_; }
          set {
            title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "pageCount" field.</summary>
        public const int PageCountFieldNumber = 4;
        private int pageCount_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int PageCount {
          get { return pageCount_; }
          set {
            pageCount_ = value;
          }
        }

        /// <summary>Field number for the "author" field.</summary>
        public const int AuthorFieldNumber = 5;
        private global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Types.Author author_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Types.Author Author {
          get { return author_; }
          set {
            author_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as BookInfo);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(BookInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Id != other.Id) return false;
          if (Title != other.Title) return false;
          if (PageCount != other.PageCount) return false;
          if (!object.Equals(Author, other.Author)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Id != 0) hash ^= Id.GetHashCode();
          if (Title.Length != 0) hash ^= Title.GetHashCode();
          if (PageCount != 0) hash ^= PageCount.GetHashCode();
          if (author_ != null) hash ^= Author.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Id != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Id);
          }
          if (Title.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Title);
          }
          if (PageCount != 0) {
            output.WriteRawTag(32);
            output.WriteInt32(PageCount);
          }
          if (author_ != null) {
            output.WriteRawTag(42);
            output.WriteMessage(Author);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Id != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
          }
          if (Title.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
          }
          if (PageCount != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageCount);
          }
          if (author_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Author);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(BookInfo other) {
          if (other == null) {
            return;
          }
          if (other.Id != 0) {
            Id = other.Id;
          }
          if (other.Title.Length != 0) {
            Title = other.Title;
          }
          if (other.PageCount != 0) {
            PageCount = other.PageCount;
          }
          if (other.author_ != null) {
            if (author_ == null) {
              author_ = new global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Types.Author();
            }
            Author.MergeFrom(other.Author);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                Id = input.ReadInt32();
                break;
              }
              case 26: {
                Title = input.ReadString();
                break;
              }
              case 32: {
                PageCount = input.ReadInt32();
                break;
              }
              case 42: {
                if (author_ == null) {
                  author_ = new global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Types.Author();
                }
                input.ReadMessage(author_);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the BookInfo message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public sealed partial class Author : pb::IMessage<Author> {
            private static readonly pb::MessageParser<Author> _parser = new pb::MessageParser<Author>(() => new Author());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<Author> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public Author() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public Author(Author other) : this() {
              name_ = other.name_;
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public Author Clone() {
              return new Author(this);
            }

            /// <summary>Field number for the "name" field.</summary>
            public const int NameFieldNumber = 1;
            private string name_ = "";
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public string Name {
              get { return name_; }
              set {
                name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other) {
              return Equals(other as Author);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(Author other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Name != other.Name) return false;
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode() {
              int hash = 1;
              if (Name.Length != 0) hash ^= Name.GetHashCode();
              if (_unknownFields != null) {
                hash ^= _unknownFields.GetHashCode();
              }
              return hash;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override string ToString() {
              return pb::JsonFormatter.ToDiagnosticString(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void WriteTo(pb::CodedOutputStream output) {
              if (Name.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Name);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize() {
              int size = 0;
              if (Name.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
              }
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(Author other) {
              if (other == null) {
                return;
              }
              if (other.Name.Length != 0) {
                Name = other.Name;
              }
              _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(pb::CodedInputStream input) {
              uint tag;
              while ((tag = input.ReadTag()) != 0) {
                switch(tag) {
                  default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                    break;
                  case 10: {
                    Name = input.ReadString();
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code