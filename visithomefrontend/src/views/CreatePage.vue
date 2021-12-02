<template>
  <div class="col-12 text-right">
    <div class="row">
      <div class="col-md-3"></div>
      <div class="col-md-6">
        <!-- <form v-model="" action="addData" method="POST"> -->
        <div class="text-danger col"></div>
        <div>
          <input type="hidden" asp-for="UserId" value="@ViewBag.userId" />
        </div>
        <div class="row form-group pb-3">
          <label for="Title" class="control-label col">عنوان</label>
          <input required v-model="Title" id="Title" class="form-control col" />
          <label for="Title" class="control-label col"></label>
          <span class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Price" class="control-label col">قیمت</label>
          <input required v-model="Price" class="form-control col" />
          <label for="Price" class="control-label col">تومان</label>
          <span asp-validation-for="Price" class="text-danger col"></span>
        </div>
        <!-- <div class="row form-group pb-3">
            <label asp-for="Zone" class="control-label col"></label>
            <select asp-for="Zone" class="form-control col">
              <option></option>
            </select>
            <span asp-validation-for="Zone" class="text-danger col"></span>
          </div> -->
        <div class="row form-group pb-3">
          <label asp-for="Parking" class="control-label col">پارکینگ</label>
          <select v-model="Parking" class="form-control col">
            <option value="false">ندارد</option>
            <option value="true">دارد</option>
          </select>
          <label asp-for="Parking" class="control-label col"></label>
          <span asp-validation-for="Parking" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label for="Warehouse" class="control-label col">انباری</label>
          <select v-model="Warehouse" id="Warehouse" class="form-control col">
            <option value="false">ندارد</option>
            <option value="true">دارد</option>
          </select>
          <label asp-for="Parking" class="control-label col"></label>
          <span asp-validation-for="Warehouse" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Elevator" class="control-label col">آسانسور</label>
          <select asp-for="Elevator" class="form-control col">
            <option value="false">ندارد</option>
            <option value="true">دارد</option>
          </select>
          <label asp-for="Floor" class="control-label col"></label>
          <span asp-validation-for="Elevator" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Floor" class="control-label col">طبقه</label>
          <input v-model="Floor" class="form-control col" />
          <label asp-for="Floor" class="control-label col"></label>
          <span asp-validation-for="Floor" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Floor" class="control-label col">مساحت</label>
          <input v-model="Floor" class="form-control col" />
          <label asp-for="Floor" class="control-label col"></label>
          <span asp-validation-for="Floor" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Floor" class="control-label col"
            >تعداد اتاق خواب</label
          >
          <input v-model="Floor" class="form-control col" />
          <label asp-for="Floor" class="control-label col"></label>
          <span asp-validation-for="Floor" class="text-danger col"></span>
        </div>
        <div class="form-group pb-3">
          <label asp-for="Floor" class="control-label">آدرس</label>
          <input v-model="Floor" class="form-control" />
          <label asp-for="Floor" class="control-label"></label>
          <span asp-validation-for="Floor" class="text-danger"></span>
        </div>
        <!-- <div class="row form-group pb-3">
            <label asp-for="YearofConstruction" class="control-label col"></label>
            <input name="year" class="form-control col" />
            <span
              asp-validation-for="YearofConstruction"
              class="text-danger col"
            </span> -->
        <!-- <span class="text-danger col">@ViewBag.ErrorMessageYear</span> -->
        <!-- </div> -->
        <div class="row form-group pb-3">
          <label asp-for="Description" class="control-label"></label>
          <textarea
            v-model="Description"
            placeholder="توضیحات"
            rows="10"
            class="form-control"
          ></textarea>
          <span asp-validation-for="Description" class="text-danger"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="ImageName" class="control-label col"></label>

          <input
            type="file"
            multiple
            name="imgUp"
            placeholder="آپلود"
            accept="image/*"
            asp-for="ImageName"
            class="form-control-file"
          />
          <span asp-validation-for="ImageName" class="text-danger col"></span>
        </div>
        <div class="form-group pt-3 row">
          <a
            v-if="Title != ''"
            href="/"
            v-on:click="addData"
            class="btn btn-primary col"
          >
            ثبت
          </a>
          <a v-else class="btn btn-primary col disabled"> ثبت </a>
        </div>
        <!-- </form> -->
      </div>
      <div class="col-md-3"></div>
      <div class="col-md-3"></div>
    </div>
  </div>
</template>

<script lang='ts'>
import { defineComponent } from "vue";
import axio from "axios";
import { uuid } from "vue-uuid";

export default defineComponent({
  name: "CreatePage",
  // mounted() {
  //   fetch("https://localhost:5001/api/Home/", {
  //     method: "POST",
  //     body: JSON.stringify(""),
  //   })
  //     .then((e) => e.json())
  //     .then((data) => (this.homeData = data));
  // },
  data() {
    return {
      Area: "",
      NumberOfBedrooms: "",
      Parking: "false",
      Warehouse: "false",
      Floor: "",
      Address: "",
      Price: "",
      Title: "",
      Description: "",
      homeData: [],
    };
  },
  methods: {
    myAlert() {
      alert("لطفا تمامی اطلاعات را بدرستی وارد نمایید");
    },
    async addData() {
      if (this.Title == "") {
        alert("لطفا تمامی اطلاعات را بدرستی وارد نمایید");
      } else {
        let result = await axio.post("https://localhost:5001/api/Home/", {
          Id: uuid.v4(),
          Area: this.Area,
          NumberOfBedrooms: this.NumberOfBedrooms,
          Parking: this.Parking,
          Warehouse: this.Warehouse,
          Floor: this.Floor,
          Address: this.Address,
          Price: this.Price,
          Title: this.Title,
          Description: this.Description,
        });
      }
    },
  },
});
</script>

<style lang="scss" scoped>
</style>
